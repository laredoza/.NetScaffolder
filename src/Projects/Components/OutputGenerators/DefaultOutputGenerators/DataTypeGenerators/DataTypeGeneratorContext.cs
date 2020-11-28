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
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.MappingDataTypes;
using DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore;
using DotNetScaffolder.Mapping.MetaData.Domain;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Context Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "Handlebars Context Generator")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4463")]
    public class DataTypeGeneratorContext : BaseDataTypeGenerator
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeGeneratorEntity"/> class.
        /// </summary>
        public DataTypeGeneratorContext()
        {
        }

        #endregion

        #region Public Properties

        public ContextDataType DataType { get; set; }

        #endregion

        #region Public Methods And Operators
        public override void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            if (dataType is ContextDataType)
            {
                this.PrepareTemplateData(dataType, domain);
                // var template = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "Context.hbr");

                var contextDataType = dataType as ContextDataType;
                var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;
                var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;

                foreach (var contextData in contextDataType.Contexts)
                {
                    var n = contextData.Models;
                    if (contextData != null)
                    {
                        // var mappingGen = new MappingGenerator();
                        var mappingDataType = dataTypes.FirstOrDefault(o => o is MappingDataType) as MappingDataType;

                        // if(mappingDataType != null)
                        // {
                        //     mappingGen.Models = domain.Tables;
                        //     mappingGen.ProjectOutputPath = contextData.OutputPath;
                        //     mappingGen.EntityNamespace = entityDataType.FullNamespace;
                        //     mappingGen.ContextData = contextData;
                        //     mappingGen.MappingDataType = mappingDataType;
                        //     mappingGen.NamingConvention = dataType.NamingConvention;
                        //     mappingGen.DataType = contextDataType;

                        //     mappingGen.Run();
                        // }


                        this.DataType = contextDataType;

                        var data = new
                        {
                            Models = domain.Tables,
                            DataType = contextDataType,
                            ContextData = contextData,
                            EntityDataType = entityDataType
                            // MappingNamespace = mappingGen.FullNamespace,
                            // MappingPostFix = mappingDataType.PostFix
                        };

                        foreach (IDriver driver in contextDataType.Drivers)
                        {
                            var template = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "ContextEFCore.hbr");
                            var projectPath = string.Format(contextData.OutputPath, driver.ParentFolder, driver.Prefix);

                            // if (driver.DriverType is EFDriverType)
                            // {
                            //     this.GenerateEFContext(driver, contextData, entityDataType.FullNamespace, mappingDataType, template, modelFilePath);
                            // }
                            if (driver.DriverType is EFCoreDriverType)
                            {
                                this.GenerateEFContext(driver, contextData, entityDataType.FullNamespace, mappingDataType, template, modelFilePath);
                            }
                            // else if (driver.DriverType is NhibernateDriverType)
                            // {
                            //     GenerateNHibernateContext(driver);
                            // }
                        }

                        // var fileContent = template(data);

                        // var outpuPath = string.Format(@"{0}\{1}{2}.g.cs", contextData.OutputFolder, driver.Prefix, ContextData.ContextName);

                        // var outputPath = contextData.OutputPath.Replace(@"\", "/");
                        // this.RenderToFile(fileContent, string.Format(@"{0}/Entities/Entity/Entity/{1}.g.cs", this.ReturnBasePath(modelFilePath), fileName));

                    }
                }

                // foreach (var model in domain.Tables)
                // {
                //     dataType.MetaData = model;

                //     var entityDataType = (dataType as ContextDataType);
                //     var fileName = model.TableName;
                //     var dtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;

                //     var data = new
                //     {
                //         FileName = fileName,
                //         Year = DateTime.Now.Year,
                //         Models = domain.Tables,
                //         DataType = entityDataType,
                //         DtoInterfaceType = dtoInterfaceType,
                //         DtoInterfaceNamespace = dtoInterfaceType.FullNamespace
                //     };

                //     foreach (var column in model.Columns)
                //     {
                //         column.ColumnNameWithNamingConvention = entityDataType.NamingConvention.ApplyNamingConvention(column.ColumnName);
                //         column.ColumnMappedToOutput = CSharpOutputMapper.MapToOutput(column);
                //     }

                //     var fileContent = template(data);

                //     var outputPath = data.DataType.OutputPath.Replace(@"\", "/");
                //     this.RenderToFile(fileContent, string.Format(@"{0}/Entities/Entity/Entity/{1}.g.cs", this.ReturnBasePath(modelFilePath), fileName));
                // }
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

        private void GenerateEFContext(IDriver driver, ContextData contextData, string entityFullNamespace, MappingDataType mappingDataType, System.Func<object, string> template, string modelFilePath)
        {
            var contextModels = contextData.Models.Where(o => contextData.Models.Exists(x => x.SchemaName == o.SchemaName && x.TableName == o.TableName)).ToList();
            string fileName = $"{driver.Prefix}{contextData.ContextName}1.g.cs"; 

            for (int i = 0; i < this.DataType.AdditionalNamespaces.Count; i++)
            {
                this.DataType.AdditionalNamespaces[i] = this.DataType.AdditionalNamespaces[i].Replace("{DriverType}", "EFCore");
            }

            var formattedModelNamesWithPostfix = new List<string>();
            var formattedModelNames = new List<string>();

            foreach (var model in contextModels)
            {
                formattedModelNamesWithPostfix.Add(string.Concat(contextData.ContextName,DataType.TransformModelName(model.TableName), mappingDataType.PostFix));
                formattedModelNames.Add( DataType.TransformModelName(model.TableName));
            }

            var data = new
            {
                FileName = fileName,
                Year = DateTime.Now.Date,
                DataType = this.DataType,
                EntityNamespace = entityFullNamespace,
                ContextData = contextData,
                Driver = driver,
                MappingNamespace = mappingDataType.FullNamespace,
                MappingPostFix = mappingDataType.PostFix,
                Models = contextModels,
                ContextNamespace = contextData.TransformFullnamespace(DataType.BaseNamespace).Replace("{DriverType}", driver.ParentFolder).Replace("{DriverPrefix}", driver.Prefix),
                FullContextName = string.Concat(driver.Prefix, contextData.ContextName),
                DriverContextAttributeIsNotEmpty = !string.IsNullOrEmpty(driver.ContextAttribute),
                FormattedModelNamesWithPostfix = formattedModelNamesWithPostfix,
                FormattedModelNames = formattedModelNames,
                ExcludedRelationships = contextData.ExcludedRelationships(contextModels),
                ReferencedTableNameTransformed = new List<string>()
            };

            foreach (var relationship in data.ExcludedRelationships)
            {
                data.ReferencedTableNameTransformed.Add(DataType.TransformModelName(relationship.ReferencedTableName));
            }

            var fileContent = template(data);
            var outpuPath = $"{contextData.OutputFolder}\\{fileName}".Replace(@"\", "/");
            this.RenderToFile(fileContent, string.Format($"{this.ReturnBasePath(modelFilePath)}/Contexts/{driver.ParentFolder}/{driver.Prefix}/{outpuPath}"));
        }

        #endregion
    }
}