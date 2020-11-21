// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOutputGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    /// <summary>
    ///     The OutputGenerator interface.
    /// </summary>
    public interface IOutputGenerator
    {
        void Generate(string packagePath, string modelFilePath);
    }
}