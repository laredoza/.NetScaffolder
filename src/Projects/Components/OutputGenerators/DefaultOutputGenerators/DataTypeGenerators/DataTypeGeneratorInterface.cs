// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorInterface.cs" company="DotnetScaffolder">
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
    /// The Interface Data Type Generator.
    /// </summary>
    [Export(typeof(IDataTypeGenerator))]
    [ExportMetadata("NameMetaData", "DataTypeGeneratorInterface")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4460")]
    public class DataTypeGeneratorInterface : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
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