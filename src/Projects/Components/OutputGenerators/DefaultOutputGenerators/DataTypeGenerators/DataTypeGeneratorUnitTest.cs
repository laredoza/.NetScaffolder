// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeGeneratorUnitTest.cs" company="DotnetScaffolder">
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
    /// The Unit Test Data Type Generator.
    /// </summary>
    // [Export(typeof(IDataTypeGenerator))]
    // [ExportMetadata("NameMetaData", "Handlebars Unit Test Generator")]
    // [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4469")]
    public class DataTypeGeneratorUnitTest : IDataTypeGenerator
    {
        public void Run(IDataType dataType, DomainDefinition domain)
        {
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