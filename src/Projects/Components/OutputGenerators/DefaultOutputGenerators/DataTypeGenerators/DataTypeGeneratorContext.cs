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
using DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6;
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
                            var template = this.RegisterTemplate(Path.GetDirectoryName(modelFilePath), "Context.hbr");
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

            var data = new
            {
                DataType = this.DataType,
                EntityNamespace = entityFullNamespace,
                ContextData = contextData,
                Driver = driver,
                MappingNamespace = mappingDataType.FullNamespace,
                MappingPostFix = mappingDataType.PostFix,
                Models = contextModels
            };

            var fileContent = template(data);

            var outpuPath = string.Format(@"{0}\{1}{0}{2}1.g.cs", contextData.OutputFolder, driver.ParentFolder, driver.Prefix, contextData.ContextName).Replace(@"\", "/");

            // var outputPath = contextData.OutputPath.Replace(@"\", "/");
            this.RenderToFile(fileContent, string.Format(@"{0}/Contexts/{1}/{2}/{3}", this.ReturnBasePath(modelFilePath), driver.ParentFolder, driver.Prefix, outpuPath));


            // var template = new ContextTemplate();
            // template.DataType = DataType;
            // template.EntityNamespace = EntityDataType.FullNamespace;
            // template.ContextData = ContextData;
            // template.Driver = driver;
            // template.MappingNamespace = MappingNamespace;
            // template.MappingPostFix = MappingPostFix;
            // template.Models = contextModels;

            // if(!string.IsNullOrEmpty(projectPath))
            // {
            // 	template.Output.Project =  projectPath;
            // }

            // template.RenderToFile(string.Format(@"{0}\{1}{2}.g.cs", ContextData.OutputFolder,driver.Prefix,ContextData.ContextName));
        }

        #endregion
    }
}