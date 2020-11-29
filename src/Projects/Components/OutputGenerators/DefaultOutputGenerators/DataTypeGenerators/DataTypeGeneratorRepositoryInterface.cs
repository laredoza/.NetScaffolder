// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorRepositoryInterface.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepoInterfaceDataTypes;
using DotNetScaffolder.Mapping.MetaData.Domain;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Repository Interface Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "Handlebars Repository Interface Generator")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4464")]
    public class DataTypeGeneratorRepositoryInterface : BaseDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            // if(dataType is RepoInterfaceDataType)
            // {					
            //     var iRepoGen = new RepoInterfaceGenerator();
            //     iRepoGen.Models = domain.Tables;
            //     iRepoGen.DataType = dataType as RepoInterfaceDataType;
            //     iRepoGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
            //     iRepoGen.Run();
            // }

            if (dataType is RepoInterfaceDataType)
            {
                this.PrepareTemplateData(dataType, domain);
                var template = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "EntityTemplate.hbr");
                

                foreach (var model in domain.Tables)
                {
                    dataType.MetaData = model;

                    var repositoryInterfaceDataType = (dataType as RepoInterfaceDataType);
                    var fileName = model.TableName;
                    var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;

                    var data = new
                    {
                        FileName = fileName,
                        Year = DateTime.Now.Year,
                        Models = domain.Tables,
                        DataType = repositoryInterfaceDataType,
                        DtoInterfaceType = dtoInterfaceType,
                        DtoInterfaceNamespace = dtoInterfaceType.FullNamespace
                    };

                    // foreach (var column in model.Columns)
                    // {
                    //     column.ColumnNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(column.ColumnName);
                    //     column.ColumnMappedToOutput = CSharpOutputMapper.MapToOutput(column);
                    // }

                    var fileContent = template(data);

                    var outputPath = data.DataType.OutputPath.Replace(@"\", "/");
                    
                    this.RenderToFile(fileContent, $"{this.ReturnBasePath(modelFilePath)}/RepositoryInterfaces/{repositoryInterfaceDataType.OutputFolder}/Entity/{fileName}.g1.cs");
                }
            }

            throw new System.NotImplementedException();
        }

        public bool UsedForDataType(IDataType dataType)
        {
            if (dataType is DtoInterfaceDataType)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}