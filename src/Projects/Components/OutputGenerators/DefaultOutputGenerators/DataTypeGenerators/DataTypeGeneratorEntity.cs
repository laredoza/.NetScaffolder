// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorEntity.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Domain;
using HandlebarsDotNet;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using DotNetScaffolder.Mapping.MetaData.Enum;
using System.Linq;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Entity Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "Handlebars Entity Generator")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4461")]
    public class DataTypeGeneratorEntity : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            var template = this.RegisterTemplate(this.ReturnRepositoryDirectoryPath(modelFilePath));
            var a = RelationshipMultiplicity.Many;
            


            // if(dataType is EntityDataType)
            // {
            //     // Debugger.Break();
            //     var entityGen = new EntityGenerator();
            //     entityGen.Models = domain.Tables;
            //     entityGen.DataType = dataType as EntityDataType;
            //     entityGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
            //     entityGen.Run();
            // }

            // EntityDataType entityDataType = dataType as EntityDataType;


            foreach (var model in domain.Tables)
            {
                var entityDataType = (dataType as EntityDataType);
                if (string.IsNullOrEmpty(entityDataType.EntityName))
                {
                    entityDataType.MetaData = model;
                }

                var fileName = entityDataType.EntityName; 
                var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;

                var data = new
                {
                    FileName = fileName,
                    Year = DateTime.Now.Year,
                    Models = domain.Tables,
                    DataType = entityDataType,
                    DtoInterfaceType = dtoInterfaceType,
                    DtoInterfaceNamespace = dtoInterfaceType.FullNamespace
                };

                var ab = entityDataType.MetaData.DistinctChildRelationships.Where(o => o.ReferencedMultiplicity == RelationshipMultiplicity.Many);

                var fileContent = template(data);
                var outputPath = data.DataType.OutputPath.Replace(@"\","/"); 
                // this.RenderToFile(fileContent, string.Format(@"{0}/{1}1.g.cs", Path.GetDirectoryName(outputPath), fileName));
                this.RenderToFile(fileContent, string.Format(@"{0}/Entities/Entity/Entity/{1}1.g.cs", this.ReturnBasePath(modelFilePath), fileName));

                // dataType.MetaData = model;
                // template.DataType = dataType;
                // template.DtoInterfaceNamespace = DtoInterfaceType.FullNamespace;

                // if(!string.IsNullOrEmpty(dataType.OutputPath))
                // {
                //     template.Output.Project = DataType.OutputPath;
                // }

                // template.RenderToFile(string.Format(@"{0}\{1}~.g.cs", dataType.OutputFolder, dataType.EntityName));	
            }

            throw new System.NotImplementedException();

        }

        public bool UsedForDataType(IDataType dataType)
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

        private System.Func<object, string> RegisterTemplate(string modelFilePath)
        {
            string source = File.ReadAllText($"{modelFilePath}/HandleBars/EntityTemplate.hbr");
            return Handlebars.Compile(source);
        }

        private void RenderToFile(string fileContent, string outputPath)
        {
            using (StreamWriter file = new StreamWriter(outputPath))
            {
                file.WriteLine(fileContent);
            }
        }

        private string ReturnRepositoryDirectoryPath(string modelFilePath)
        {
            return Path.GetDirectoryName(modelFilePath);
        }
        private string ReturnBasePath(string modelFilePath)
        {
            var path = Directory.GetParent(Path.GetDirectoryName(this.ReturnRepositoryDirectoryPath(modelFilePath)));
            return  path.Parent.FullName;
        }
    }
}