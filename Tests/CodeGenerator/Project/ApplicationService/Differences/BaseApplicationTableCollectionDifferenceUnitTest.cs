using System;
using DotNetScaffolder.Mapping.ApplicationServices.Differences;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Project.ApplicationService.Differences
{
    using DotNetScaffolder.Components.Common.Contract;

    /// <summary>
    /// The base application table collection difference unit test.
    /// </summary>
    [TestClass]
    public class BaseApplicationTableCollectionDifferenceUnitTest
    {
        /// <summary>
        /// Gets or sets the difference.
        /// </summary>
        public IApplicationTableCollectionDifference Difference { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
