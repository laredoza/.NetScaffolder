// --------------------------------------------------------------------------------------------------------------------
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

            return null;
        }
    }
}