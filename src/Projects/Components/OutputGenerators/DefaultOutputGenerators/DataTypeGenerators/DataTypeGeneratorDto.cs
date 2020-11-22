// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorDto.cs" company="DotnetScaffolder">
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
    /// The Dto Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Dto Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4462")]
    public class DataTypeGeneratorDto : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
            // if(dataType is DtoDataType)
            // {
            //     var iDtoGen = new DtoGenerator();
            //     iDtoGen.Models = domain.Tables;
            //     iDtoGen.DataType = dataType as DtoDataType;
            //     iDtoGen.DtoInterfaceType = dataTypes.FirstOrDefault(o => o is DtoInterfaceDataType) as DtoInterfaceDataType;
            //     iDtoGen.Run();
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