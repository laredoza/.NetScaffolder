// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorEntity.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using DotNetScaffolder.Components.Common;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.MappingDataTypes;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Entity Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Entity Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4461")]
    public class DataTypeGeneratorEntity : BaseDataTypeGenerator
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeGeneratorEntity"/> class.
        /// </summary>
        public DataTypeGeneratorEntity()
        {
        }

        #endregion

        #region Public Properties


        #endregion

        #region Public Methods And Operators
        public override void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            if (dataType is EntityDataType)
            {
                this.PrepareTemplateData(dataType, domain);
                var template = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "EntityTemplate.hbr");
                

                foreach (var model in domain.Tables)
                {
                    dataType.MetaData = model;

                    var entityDataType = (dataType as EntityDataType);
                    var fileName = model.TableName;
                    var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;

                    var data = new
                    {
                        FileName = fileName,
                        Year = DateTime.Now.Year,
                        Models = domain.Tables,
                        DataType = entityDataType,
                        DtoInterfaceType = dtoInterfaceType,
                        DtoInterfaceNamespace = dtoInterfaceType.FullNamespace
                    };

                    foreach (var column in model.Columns)
                    {
                        column.ColumnNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(column.ColumnName);
                        column.ColumnMappedToOutput = CSharpOutputMapper.MapToOutput(column);
                    }

                    var fileContent = template(data);

                    var outputPath = data.DataType.OutputPath.Replace(@"\", "/");
                    
                    this.RenderToFile(fileContent, string.Format(@"{0}/Entities/Entity/Entity/{1}.g.cs", this.ReturnBasePath(modelFilePath), fileName));
                }
            }
        }
        public override bool UsedForDataType(IDataType dataType)
        {
            if (dataType is EntityDataType)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Other Methods

        #endregion
    }
}