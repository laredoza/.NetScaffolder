using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    using System.IO;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenericAdoSourceTypeUnitTest : BaseSourceTypeUnitTest
    {
        [TestMethod]
        public void GenericAdoSourceTypeUnitTest_Import()
        {
            GenericAdoSourceType import = new GenericAdoSourceType();
            DatabaseModel databaseModel = import.Import(new AdoSourceOptions());
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }
    }
}
