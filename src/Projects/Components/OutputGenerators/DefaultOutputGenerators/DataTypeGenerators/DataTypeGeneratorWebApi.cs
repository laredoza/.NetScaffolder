// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorWebApi.cs" company="DotnetScaffolder">
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
    /// The Web Api Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Web Api Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4467")]
    public class DataTypeGeneratorWebApi : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
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