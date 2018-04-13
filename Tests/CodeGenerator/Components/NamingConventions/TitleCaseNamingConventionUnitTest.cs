// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNamingConventionUnitTest.cs" company="DotnetScaffolder">
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
    ///     Tests TitleCaseNamingConvention
    /// </summary>
    [TestClass]
    public class TitleCaseNamingConventionUnitTest
    {
        #region Public methods and operators

        /// <summary>
        ///     Tests ApplyNamingConvention
        /// </summary>
        [TestMethod]
        public void TitleCaseNamingConventionUnitTest_ApplyNamingConvention()
        {
            TitleCaseNamingConvention namingConvention = new TitleCaseNamingConvention();
            Assert.AreEqual(
                "Title Case",
                namingConvention.ApplyNamingConvention("title case"),
                "The result should be TitleCase");

            Assert.AreEqual(
                "Titlecase",
                namingConvention.ApplyNamingConvention("titlecase"),
                "The result should be Titlecase");
        }

        #endregion
    }
}