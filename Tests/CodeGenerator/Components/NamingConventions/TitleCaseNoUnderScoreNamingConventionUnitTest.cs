// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNoUnderScoreNamingConventionUnitTest.cs" company="">
//   
// </copyright>
// <summary>
//   The title case no under score naming convention unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeGenerator.Test.Components.NamingConventions
{
    #region Using

    using Contractors.NamingConventions.DefaultNamingConventions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// Tests TitleCaseNoUnderScoreNamingConvention
    /// </summary>
    [TestClass]
    public class TitleCaseNoUnderScoreNamingConventionUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// Test ApplyNamingConvention
        /// </summary>
        [TestMethod]
        public void TitleCaseNoUnderScoreNamingConventionUnitTest_()
        {
            TitleCaseNoUnderScoreNamingConvention namingConvention = new TitleCaseNoUnderScoreNamingConvention();
            Assert.AreEqual("TestMe", namingConvention.ApplyNamingConvention("Test_Me"), "The result should be TestMe");
            Assert.AreEqual(
                "TestMeNow",
                namingConvention.ApplyNamingConvention("Test_Menow"),
                "The result should be TestMeNow");
        }

        #endregion
    }
}