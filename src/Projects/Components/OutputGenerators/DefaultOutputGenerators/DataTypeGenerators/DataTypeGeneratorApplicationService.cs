// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorApplicationService.cs" company="DotnetScaffolder">
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
    /// The Application Service Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))
    // [ExportMetadata("NameMetaData", "Handlebars Application Service Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4466")]
    public class DataTypeGeneratorApplicationService : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
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