// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VBLanguageOutput.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.LanguageOutputs.DefaultLanguageOutput
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     CSharp LanguageOutput.
    /// </summary>
    /// <example>securityview will be SecurityView</example>
    [Export(typeof(ILanguageOutput))]
    [ExportMetadata("NameMetaData", "VB")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class CSharpLanguageOutput : ILanguageOutput
    {
    }
}