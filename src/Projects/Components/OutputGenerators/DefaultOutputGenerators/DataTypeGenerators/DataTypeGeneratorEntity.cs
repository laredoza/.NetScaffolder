// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorEntity.cs" company="DotnetScaffolder">
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
    /// The Entity Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "Handlebars Entity Generator")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4461")]
    public class DataTypeGeneratorEntity : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
            // if(dataType is EntityDataType)
            // {
            //     // Debugger.Break();
            //     var entityGen = new EntityGenerator();
            //     entityGen.Models = domain.Tables;
            //     entityGen.DataType = dataType as EntityDataType;
            //     entityGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
            //     entityGen.Run();
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