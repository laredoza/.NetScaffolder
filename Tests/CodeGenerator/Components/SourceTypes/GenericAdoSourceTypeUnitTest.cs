// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericAdoSourceTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    #region Usings

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The generic ado source type unit test.
    /// </summary>
    [TestClass]
    public class GenericAdoSourceTypeUnitTest : BaseSourceTypeUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The generic ado source type unit test_ import.
        /// </summary>
        [TestMethod]
        public void GenericAdoSourceTypeUnitTest_Import()
        {
            GenericAdoSourceType import = new GenericAdoSourceType();
            DatabaseModel databaseModel = import.Import(new AdoSourceOptions());
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }

        #endregion
    }
}