﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HandleBarsOutputGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings

    using System.ComponentModel.Composition;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using DotNetScaffolder.Core.Configuration;

    #endregion

    /// <summary>
    /// The t4 output generator.
    /// </summary>
    [Export(typeof(IOutputGenerator))]
    [ExportMetadata("NameMetaData", "HandleBars")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4413")]
    public class HandleBarsOutputGenerator : BaseOutputGenerator
    {
        protected override void ExecuteGenerators(List<IDataType> dataTypes, DomainDefinition domain)
        {
            // Execute generation using initialised data types
            foreach (var dataType in dataTypes)
            {
                var dataTypeGenerator = this.ReturnDataTypeGenerator(dataType);
                if (dataTypeGenerator != null)
                {
                    dataTypeGenerator.Run(dataType, domain);
                }
                // if(dataType is DtoInterfaceDataType)
                // {
                //     // Debugger.Break();
                //     var iDtoGen = new DtoInterfaceGenerator();
                //     iDtoGen.Models = domain.Tables;
                //     iDtoGen.DataType = dataType as DtoInterfaceDataType;
                //     iDtoGen.Run();
                // }

                // if(dataType is EntityDataType)
                // {
                //     // Debugger.Break();
                //     var entityGen = new EntityGenerator();
                //     entityGen.Models = domain.Tables;
                //     entityGen.DataType = dataType as EntityDataType;
                //     entityGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
                //     entityGen.Run();
                // }

                // if(dataType is DtoDataType)
                // {
                //     var iDtoGen = new DtoGenerator();
                //     iDtoGen.Models = domain.Tables;
                //     iDtoGen.DataType = dataType as DtoDataType;
                //     iDtoGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
                //     iDtoGen.Run();
                // }

                // if(dataType is ContextDataType)
                // {			
                //     var contextDataType = dataType as ContextDataType;
                //     var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;

                //     foreach(var contextData in contextDataType.Contexts)
                //     {					
                //         if(contextData != null)
                //         {
                //             var mappingGen = new MappingGenerator();
                //             var mappingDataType = dataTypes.FirstOrDefault(o => o is MappingDataType) as MappingDataType;

                //             if(mappingDataType != null)
                //             {
                //                 mappingGen.Models = domain.Tables;
                //                 mappingGen.ProjectOutputPath = contextData.OutputPath;
                //                 mappingGen.EntityNamespace = entityDataType.FullNamespace;
                //                 mappingGen.ContextData = contextData;
                //                 mappingGen.MappingDataType = mappingDataType;
                //                 mappingGen.NamingConvention = dataType.NamingConvention;
                //                 mappingGen.DataType = contextDataType;

                //                 mappingGen.Run();
                //             }

                //             var contxtGen = new ContextGenerator();

                //             contxtGen.Models = domain.Tables;
                //             contxtGen.DataType = contextDataType;
                //             contxtGen.ContextData = contextData;
                //             contxtGen.EntityDataType = entityDataType;
                //             contxtGen.MappingNamespace = mappingGen.FullNamespace;
                //             contxtGen.MappingPostFix = mappingDataType.PostFix;
                //             contxtGen.Run();
                //         }
                //     }
                // }

                // if(dataType is RepoInterfaceDataType)
                // {					
                //     var iRepoGen = new RepoInterfaceGenerator();
                //     iRepoGen.Models = domain.Tables;
                //     iRepoGen.DataType = dataType as RepoInterfaceDataType;
                //     iRepoGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
                //     iRepoGen.Run();
                // }

                // if(dataType is RepositoryDataType)
                // {
                //     var iRepoGen = new RepositoryGenerator();
                //     iRepoGen.Models = domain.Tables;
                //     iRepoGen.DataType = dataType as RepositoryDataType;
                //     iRepoGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
                //     iRepoGen.EntityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;
                //     iRepoGen.RepositoryInterfaceNamespace = (dataTypes.FirstOrDefault(o => o is RepoInterfaceDataType) as RepoInterfaceDataType).FullNamespace; 
                //     iRepoGen.Run();
                // }

                // if (dataType is ApplicationServiceDataType)
                // {
                //     //Debugger.Break();
                //     ApplicationServiceDataType applicationDataType = dataType as ApplicationServiceDataType;
                //     var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;

                //     var applicationServiceGenerator = new ApplicationServiceGenerator {
                //             DataType = applicationDataType,
                //             DtoInterfaceDataType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType,
                //             RepositoryInterfaceNamespace = (dataTypes.FirstOrDefault(o => o is RepoInterfaceDataType) as RepoInterfaceDataType).FullNamespace, 
                //    };

                //     applicationServiceGenerator.Run();
                // }

                // if (dataType is WebApiServiceDataType)
                // {
                //     WebApiServiceDataType webApiServiceDataType = dataType as WebApiServiceDataType;
                //     var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;

                //     var applicationServiceGenerator = new WebApiGenerator {
                //             DataType = webApiServiceDataType,
                //             ApplicationServiceDataType = dataTypes.FirstOrDefault(o => o is ApplicationServiceDataType) as ApplicationServiceDataType,
                //             DtoInterfaceDataType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType
                //             };

                //     applicationServiceGenerator.Run();
                // }

                // if(dataType is StructureMapDataType)
                // {
                //     var contextDataType =  dataTypes.FirstOrDefault(o => o is ContextDataType) as ContextDataType;;

                //     StructureMapGenerator structureMapGenerator = new StructureMapGenerator();
                //     structureMapGenerator.DataType = dataType as StructureMapDataType;
                //     structureMapGenerator.Drivers = contextDataType.Drivers;
                //     structureMapGenerator.ApplicationServiceDataType = dataTypes.FirstOrDefault(o => o is ApplicationServiceDataType) as ApplicationServiceDataType;
                //     structureMapGenerator.Models = domain.Tables;
                //     structureMapGenerator.RepositoryDataType = dataTypes.FirstOrDefault(o => o is RepositoryDataType) as RepositoryDataType;
                //     structureMapGenerator.RepoInterfaceDataType = dataTypes.FirstOrDefault(o => o is RepoInterfaceDataType) as RepoInterfaceDataType;
                //     structureMapGenerator.ContextData = contextDataType.Contexts.Any(o => o.IsDefault) ? contextDataType.Contexts.First(o => o.IsDefault) : contextDataType.Contexts.FirstOrDefault();
                //     structureMapGenerator.Drivers = contextDataType.Drivers;
                //     structureMapGenerator.ContextDataType = contextDataType;
                //     structureMapGenerator.InterfaceDatabasePath = (dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType).FullNamespace; 
                //     structureMapGenerator.NameSpaces = (dataType as StructureMapDataType).AdditionalNamespaces; 

                //     structureMapGenerator.Run();
                // }

                //if(dataType is UnitTestDataType)
                //{
                //var dtoDataType = dataTypes.FirstOrDefault(o => o is DtoDataType) as DtoDataType;
                //var dtoInterfaceDataType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
                //var entityDataType = dataTypes.FirstOrDefault(o => o is EntityDataType) as EntityDataType;
                //
                //var unitTestGen = new BaseUnitTestGenerator();
                //unitTestGen.DataType = dataType as UnitTestDataType; 
                //            estGen.Models = domain.Tables;
                //unitTestGen.DtoNamespace = dtoDataType.FullNamespace;
                //unitTestGen.DtoInterfaceNamespace = dtoInterfaceDataType.FullNamespace;
                //unitTestGen.EntityNamespace = entityDataType.FullNamespace;
                //unitTestGen.Run();
                //}
            }

        }

        private IDataTypeGenerator ReturnDataTypeGenerator(IDataType dataType)
        {
            IDataTypeGenerator result = null;
            foreach (var dataGenerator in ScaffoldConfig.DataTypeGenerators)
            {
                result = dataGenerator.Value;

                if (result.UsedForDataType(dataType))
                {
                    return result;
                }
            }

            return result;
        }
    }
}