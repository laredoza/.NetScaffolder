// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNoUnderScoreNamingConventionUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.NamingConventions
{
    #region Usings

    using DotNetScaffolder.Components.NamingConventions.DefaultNamingConventions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     Tests TitleCaseNoUnderScoreNamingConvention
    /// </summary>
    [TestClass]
    public class TitleCaseNoUnderScoreNamingConventionUnitTest
    {
        #region Public methods and operators

        /// <summary>
        ///     Test ApplyNamingConvention
        /// </summary>
        [TestMethod]
        public void TitleCaseNoUnderScoreNamingConventionUnitTest_()
        {
            TitleCaseNoUnderScoreNamingConvention namingConvention = new TitleCaseNoUnderScoreNamingConvention();
            Assert.AreEqual("TestMe", namingConvention.ApplyNamingConvention("Test_Me"), "The result should be TestMe");
            Assert.AreEqual(
                "TestMenow",
                namingConvention.ApplyNamingConvention("Test_Menow"),
                "The result should be TestMeNow");
        }

        #endregion
    }
}