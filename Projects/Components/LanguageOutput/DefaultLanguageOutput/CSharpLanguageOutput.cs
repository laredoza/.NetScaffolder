using DotNetScaffolder.Components.Common.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.LanguageOutputs.DefaultLanguageOutput
{
    /// <summary>
    /// The title case naming convention.
    /// </summary>
    /// <example>securityview will be SecurityView</example>
    [Export(typeof(ILanguageOutput))]
    [ExportMetadata("NameMetaData", "C#")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class CSharpLanguageOutput : ILanguageOutput
    {
    }
}