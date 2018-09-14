// --------------------------------------------------------------------------------------------------------------------
// <copyright file="T4OutputGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    /// The t 4 output generator.
    /// </summary>
    [Export(typeof(IOutputGenerator))]
    [ExportMetadata("NameMetaData", "T4")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class T4OutputGenerator : IOutputGenerator
    {
    }
}