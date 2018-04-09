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
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EdmxSourceTypeUnitTest : BaseSourceTypeUnitTest
    {
        [TestMethod]
        public void EdmxSourceTypeUnitTest_Import()
        {
            EdmxSourceType import = new EdmxSourceType();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\model.edmx");
            DatabaseModel databaseModel = import.Import(new FileSourceOptions { Path = filePath });
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }
    }
}
