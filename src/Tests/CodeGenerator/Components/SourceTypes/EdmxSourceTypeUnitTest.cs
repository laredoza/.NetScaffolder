// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    #region Usings

    using System.IO;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The edmx source type unit test.
    /// </summary>
    [TestClass]
    public class EdmxSourceTypeUnitTest : BaseSourceTypeUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The edmx source type unit test_ import.
        /// </summary>
        [TestMethod]
        public void EdmxSourceTypeUnitTest_Import()
        {
            EdmxSourceType import = new EdmxSourceType();
            this.SourceType = import;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\model.edmx");
            DatabaseModel databaseModel = import.Import(new FileSourceOptions { Path = filePath });
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }

        #endregion
    }
}