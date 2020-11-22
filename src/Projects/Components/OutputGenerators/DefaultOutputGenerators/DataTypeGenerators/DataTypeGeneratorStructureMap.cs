// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorStructureMap.cs" company="DotnetScaffolder">
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
    /// The Structure Map Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars StructureMap Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4468")]
    public class DataTypeGeneratorStructureMap : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
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