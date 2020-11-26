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
using DotNetScaffolder.Components.Common;

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
            try
            {
                // var template1 = this.RegisterTemplate(this.ReturnRepositoryDirectoryPath(modelFilePath));

            }
            catch (System.Exception ex)
            {

                throw;
            }

            var template = this.RegisterTemplate(this.ReturnRepositoryDirectoryPath(modelFilePath));



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
                foreach (var relationship in model.DistinctChildRelationshipsWithManyManyMultiplicity)
                {
                    relationship.ChildRelationshipNameWithNamingConvention = RelationshipNameFormatting.FormatName(relationship.ReferencedTableName, relationship.RelationshipAlias, dataType.NamingConvention);
                    relationship.ChildReferencedTableNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(relationship.ReferencedTableName);
                }

                foreach (var relationship in model.DistinctParentRelationships)
                {
                    relationship.ParentRelationshipNameWithNamingConvention = RelationshipNameFormatting.FormatName(relationship.ReferencedTableName, relationship.RelationshipAlias, dataType.NamingConvention);
                    relationship.ParentReferencedTableNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(relationship.ReferencedTableName);
                }
                entityDataType.MetaData = model;

                if (entityDataType.MetaData.PrimaryKeyColumns != null && entityDataType.MetaData.PrimaryKeyColumns.Count > 0)
                {
                    entityDataType.MetaData.PrimaryKeyColumns[0].IsFirstPrimaryKeyColumn = true;
                }

                var fileName = model.TableName;
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

                foreach (var column in model.Columns)
                {
                    column.ColumnNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(column.ColumnName);
                    column.ColumnMappedToOutput = CSharpOutputMapper.MapToOutput(column);
                }

                var fileContent = template(data);

                var outputPath = data.DataType.OutputPath.Replace(@"\", "/");
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
            return path.Parent.FullName;
        }
    }
}