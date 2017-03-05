using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Components.Common.Contract;
using System.ComponentModel.Composition;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    [Export(typeof(IOutputGenerator))]
    [ExportMetadata("NameMetaData", "T4")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class T4OutputGenerator : IOutputGenerator
    {
    }    
}
