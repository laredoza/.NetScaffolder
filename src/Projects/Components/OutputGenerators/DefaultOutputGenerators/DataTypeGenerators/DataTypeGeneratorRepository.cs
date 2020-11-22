// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorRepository.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
using DotNetScaffolder.Mapping.MetaData.Domain;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Repository Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Repository Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4465")]
    public class DataTypeGeneratorRepository : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
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