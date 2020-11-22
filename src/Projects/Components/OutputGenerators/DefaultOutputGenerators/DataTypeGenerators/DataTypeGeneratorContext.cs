// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorContext.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using DotNetScaffolder.Mapping.MetaData.Domain;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Context Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Context Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4463")]
    public class DataTypeGeneratorContext : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
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