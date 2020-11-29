// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorContext.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.Formatting;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.MappingDataTypes;
using DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Model;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Efcore Context Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "Handlebars EFCore Context Generator")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4463")]
    public class DataTypeGeneratorEfcoreContext : BaseDataTypeGenerator
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeGeneratorEfcoreContext"/> class.
        /// </summary>
        public DataTypeGeneratorEfcoreContext()
        {
        }

        #endregion

        #region Public Properties

        public DomainDefinition DomainDefinition { get; set; }
        #endregion

        #region Public Methods And Operators
        public override void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            if (dataType is ContextDataType)
            {
                this.DomainDefinition = domain;
                this.PrepareTemplateData(dataType, domain);
                var contextDataType = dataType as ContextDataType;
                var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;
                var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;

                foreach (var contextData in contextDataType.Contexts)
                {
                    if (contextData != null)
                    {
                        var mappingDataType = dataTypes.FirstOrDefault(o => o is MappingDataType) as MappingDataType;
                        foreach (IDriver driver in contextDataType.Drivers)
                            if (driver != null)
                            {
                                var contextTemplate = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "ContextEFCore.hbr");
                                var contextTemplateCustom = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "ContextEFCoreCustom.hbr");
                                var efCoreTemplate = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "EFCoreMapping.hbr");

                                var projectPath = string.Format(contextData.OutputPath, driver.ParentFolder, driver.Prefix);

                                // if (driver.DriverType is EFDriverType)
                                // {
                                //     this.GenerateEFContext(driver, contextData, entityDataType.FullNamespace, mappingDataType, template, modelFilePath);
                                // }
                                if (driver.DriverType is EFCoreDriverType)
                                {
                                    this.GenerateContext(driver, contextData, entityDataType.FullNamespace, mappingDataType, contextTemplate, modelFilePath, contextDataType);
                                    this.GenerateCustomContext(driver, contextData, entityDataType.FullNamespace, mappingDataType, contextTemplateCustom, modelFilePath, contextDataType);
                                    this.GenerateModel(driver, contextData, entityDataType.FullNamespace, mappingDataType, efCoreTemplate, modelFilePath, contextDataType);
                                }
                                // else if (driver.DriverType is NhibernateDriverType)
                                // {
                                //     GenerateNHibernateContext(driver);
                                // }
                            }
                    }
                }
            }
        }
        public override bool UsedForDataType(IDataType dataType)
        {
            if (dataType is ContextDataType)
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

        private void GenerateContext(
            IDriver driver,
            ContextData contextData,
            string entityFullNamespace,
            MappingDataType mappingDataType,
            System.Func<object, string> template,
            string modelFilePath,
            ContextDataType dataType)
        {
            var contextModels = contextData.Models.Where(o => contextData.Models.Exists(x => x.SchemaName == o.SchemaName && x.TableName == o.TableName)).ToList();
            string fileName = $"{driver.Prefix}{contextData.ContextName}.g.cs";

            for (int i = 0; i < dataType.AdditionalNamespaces.Count; i++)
            {
                dataType.AdditionalNamespaces[i] = dataType.AdditionalNamespaces[i].Replace("{DriverType}", "EFCore");
            }

            var formattedModelNamesWithPostfix = new List<string>();
            var formattedModelNames = new List<string>();

            foreach (var model in contextModels)
            {
                formattedModelNamesWithPostfix.Add(string.Concat(contextData.ContextName, dataType.TransformModelName(model.TableName), mappingDataType.PostFix));
                formattedModelNames.Add(dataType.TransformModelName(model.TableName));
            }

            var data = new
            {
                FileName = fileName,
                Year = DateTime.Now.Date,
                DataType = dataType,
                EntityNamespace = entityFullNamespace,
                ContextData = contextData,
                Driver = driver,
                MappingNamespace = mappingDataType.FullNamespace,
                MappingPostFix = mappingDataType.PostFix,
                Models = contextModels,
                ContextNamespace = contextData.TransformFullnamespace(dataType.BaseNamespace).Replace("{DriverType}", driver.ParentFolder).Replace("{DriverPrefix}", driver.Prefix),
                FullContextName = string.Concat(driver.Prefix, contextData.ContextName),
                DriverContextAttributeIsNotEmpty = !string.IsNullOrEmpty(driver.ContextAttribute),
                FormattedModelNamesWithPostfix = formattedModelNamesWithPostfix,
                FormattedModelNames = formattedModelNames,
                ExcludedRelationships = contextData.ExcludedRelationships(contextModels),
                ReferencedTableNameTransformed = new List<string>()
            };

            foreach (var relationship in data.ExcludedRelationships)
            {
                data.ReferencedTableNameTransformed.Add(dataType.TransformModelName(relationship.ReferencedTableName));
            }

            var fileContent = template(data);
            var outpuPath = $"{contextData.OutputFolder}\\{fileName}".Replace(@"\", "/");
            this.RenderToFile(fileContent, $"{this.ReturnBasePath(modelFilePath)}/Contexts/{driver.ParentFolder}/{driver.Prefix}/{outpuPath}");
        }

        private void GenerateCustomContext(
            IDriver driver,
            ContextData contextData,
            string entityFullNamespace,
            MappingDataType mappingDataType,
            System.Func<object, string> template,
            string modelFilePath,
            ContextDataType dataType)
        {
            var contextModels = contextData.Models.Where(o => contextData.Models.Exists(x => x.SchemaName == o.SchemaName && x.TableName == o.TableName)).ToList();
            string fileName = $"{driver.Prefix}{contextData.ContextName}.cs";

            for (int i = 0; i < dataType.AdditionalNamespaces.Count; i++)
            {
                dataType.AdditionalNamespaces[i] = dataType.AdditionalNamespaces[i].Replace("{DriverType}", "EFCore");
            }

            var formattedModelNamesWithPostfix = new List<string>();
            var formattedModelNames = new List<string>();

            foreach (var model in contextModels)
            {
                formattedModelNamesWithPostfix.Add(string.Concat(contextData.ContextName, dataType.TransformModelName(model.TableName), mappingDataType.PostFix));
                formattedModelNames.Add(dataType.TransformModelName(model.TableName));
            }

            // I'm exposing a lot of properties here to the template even though they're not required. Might be usefull to someone
            var data = new
            {
                FileName = fileName,
                Year = DateTime.Now.Date,
                DataType = dataType,
                EntityNamespace = entityFullNamespace,
                ContextData = contextData,
                Driver = driver,
                MappingNamespace = mappingDataType.FullNamespace,
                MappingPostFix = mappingDataType.PostFix,
                Models = contextModels,
                ContextNamespace = contextData.TransformFullnamespace(dataType.BaseNamespace).Replace("{DriverType}", driver.ParentFolder).Replace("{DriverPrefix}", driver.Prefix),
                FullContextName = string.Concat(driver.Prefix, contextData.ContextName),
                DriverContextAttributeIsNotEmpty = !string.IsNullOrEmpty(driver.ContextAttribute),
                FormattedModelNamesWithPostfix = formattedModelNamesWithPostfix,
                FormattedModelNames = formattedModelNames,
                ExcludedRelationships = contextData.ExcludedRelationships(contextModels),
                ReferencedTableNameTransformed = new List<string>()
            };

            foreach (var relationship in data.ExcludedRelationships)
            {
                data.ReferencedTableNameTransformed.Add(dataType.TransformModelName(relationship.ReferencedTableName));
            }

            var fileContent = template(data);
            var outpuPath = $"{contextData.OutputFolder}\\{fileName}".Replace(@"\", "/");
            outpuPath = $"{this.ReturnBasePath(modelFilePath)}/Contexts/{driver.ParentFolder}/{driver.Prefix}/{outpuPath}";

            if (!File.Exists(outpuPath))
            {
                this.RenderToFile(fileContent, outpuPath);
            }
        }

        private void GenerateModel(
            IDriver driver,
            ContextData contextData,
            string entityFullNamespace,
            MappingDataType mappingDataType,
            System.Func<object, string> template,
            string modelFilePath,
            ContextDataType dataType)
        {
            var contextModelsWithoutData = contextData.Models.Where(o => contextData.Models.Exists(x => x.SchemaName == o.SchemaName && x.TableName == o.TableName)).ToList();
            List<Table> contextModels = new List<Table>();

            foreach (var model in contextModelsWithoutData)
            {
                var domainModel = this.DomainDefinition.Tables.FirstOrDefault(x => x.SchemaName == model.SchemaName && x.TableName == model.TableName);

                if (domainModel != null)
                {
                    contextModels.Add(domainModel);
                }
            }

            for (int i = 0; i < dataType.AdditionalNamespaces.Count; i++)
            {
                dataType.AdditionalNamespaces[i] = dataType.AdditionalNamespaces[i].Replace("{DriverType}", "EFCore");
            }

            var formattedModelNamesWithPostfix = new List<string>();
            var formattedModelNames = new List<string>();

            foreach (var model in contextModels)
            {
                string fileName = $"{string.Concat(contextData.ContextName, mappingDataType.ModelName)}{dataType.TransformModelName(model.TableName)}{mappingDataType.PostFix}.g1.cs";


                formattedModelNamesWithPostfix.Add(string.Concat(contextData.ContextName, dataType.TransformModelName(model.TableName), mappingDataType.PostFix));
                formattedModelNames.Add(dataType.TransformModelName(model.TableName));

                var primaryKeyColumn = model.Columns.First(o => o.IsPrimaryKey);

                // I'm exposing a lot of properties here to the template even though they're not required. Might be usefull to someone
                var data = new {
                    FileName = fileName,
                    Year = DateTime.Now.Date,
                    DataType = dataType,
                    EntityNamespace = entityFullNamespace,
                    ContextNamespace = contextData.TransformFullnamespace(dataType.BaseNamespace).Replace("{DriverType}", driver.ParentFolder).Replace("{DriverPrefix}", driver.Prefix),
                    FullContextName = string.Concat(driver.Prefix, contextData.ContextName),
                    ModelName = dataType.NamingConvention == null ? model.TableName : dataType.NamingConvention.ApplyNamingConvention(model.TableName),
                    SchemaName = driver.ForceSchemaToUppercase ? model.SchemaName.ToUpper() : model.TableName,
                    AliasedTableName = driver.AsAlias(model.TableName),
                    AliasedSchemaName = driver.AsAlias(driver.ForceSchemaToUppercase ? model.SchemaName.ToUpper() : model.TableName),
                    HasCompositeKey = model.PrimaryKeyCount > 1,
                    PrimaryKeyColumnKey = primaryKeyColumn,
                    PrimaryKeyColumns = model.Columns.Where(o => o.IsPrimaryKey),
                    PrimaryKeyColumnsTransformedNames = new Dictionary<string, string>(),
                    PrimaryKeyColumnName = dataType.NamingConvention.ApplyNamingConvention(primaryKeyColumn.ColumnName),
                    TransformedDbGeneratedPrimaryKey = driver.DriverType.TransformDbGeneratedKey(model),
                    TransformedCompositeKey = NameFormatting.TransformCompositeKeys(model.Columns.Where(o => o.IsPrimaryKey), "t", dataType.NamingConvention),
                    Columns = new List<dynamic>(),
                    IndexColumns = new List<string>(),
                    TransformRelationships = new List<string>(),
                    ReferencedTableNameTransformed = new List<string>(),
                    ExcludedRelationships = contextData.ExcludedRelationships(contextModels),
                    ContextData = contextData,
                    Driver = driver,
                    Model = model,
                    // MappingNamespace = mappingDataType.FullNamespace,
                    // MappingPostFix = mappingDataType.PostFix,
                    Models = contextModels,
                    // DriverContextAttributeIsNotEmpty = !string.IsNullOrEmpty(driver.ContextAttribute),
                    // FormattedModelNamesWithPostfix = formattedModelNamesWithPostfix,
                    // FormattedModelNames = formattedModelNames
                };

                foreach (var column in data.PrimaryKeyColumns)
                {
                    data.PrimaryKeyColumnsTransformedNames.Add(column.ColumnName, dataType.NamingConvention.ApplyNamingConvention(column.ColumnName));
                }

                foreach (var relationship in data.ExcludedRelationships)
                {
                    data.ReferencedTableNameTransformed.Add(dataType.TransformModelName(relationship.ReferencedTableName));
                }

                foreach (var table in model.Columns)
                {
                   foreach(var idx in model.Indexes.Where(o => o.IndexType != IndexType.PrimaryKey && o.Columns.Contains(table.ColumnName))){
                       data.IndexColumns.Add(driver.TransformIndex(idx));
                   } 
                }

                foreach (var column in model.Columns)
                {
                    data.Columns.Add( new {
                        ColumnName = column.ColumnName,
                        ColumnNameWithTransformation =  dataType.NamingConvention.ApplyNamingConvention(column.ColumnName),
                        Length = column.Length,
                        ColumnPrecision = driver.DriverType.TransformColumnPrecision(column),
                        ColumnLengthIsLargerThan0 = column.Length > 0,
                        IsRequired = column.IsRequired,
                        IsDecimal = (column.Precision > 0 && !column.InValidPrecisionGeneration) || column.Scale > 0,
                        TransformColumnPrecision = driver.DriverType.TransformColumnPrecision(column)
                    });
                }

                foreach(var rel in model.Relationships.Where(o => contextData.HasModel(o))){
                    data.TransformRelationships.Add(driver.DriverType.TransformRelationship(model.TableName, rel, data.Models, model.Relationships.Where(o => contextData.HasModel(o)), dataType.NamingConvention));
                }

                var fileContent = template(data);

                var outpuPath = $"{this.ReturnBasePath(modelFilePath)}/Contexts/{driver.ParentFolder}/{driver.Prefix}/{mappingDataType.OutputFolder}\\{string.Concat(driver.Prefix, contextData.ContextName)}\\{fileName}".Replace(@"\", "/");
                this.RenderToFile(fileContent, outpuPath);
            }
        }

        #endregion
    }
}