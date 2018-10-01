// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    #region Usings

    using System.Configuration;
    using System.IO;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.MySql;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The edmx source type unit test.
    /// </summary>
    [TestClass]
    public class MySqlSourceTypeUnitTest : BaseSourceTypeUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The edmx source type unit test_ import.
        /// </summary>
        [TestMethod]
        public void MySqlSourceTypeUnitTest_Import()
        {
            MySqlAdoSourceType import = new MySqlAdoSourceType();
            this.SourceType = import;
            
            AdoSourceOptions sourceOptions = new AdoSourceOptions { ProviderName = "MySql.Data.MySqlClient", ConnectionString = ConfigurationManager.ConnectionStrings["RepoTestMySql"].ConnectionString };
            sourceOptions.Schemas.Add("repotest");

            DatabaseModel databaseModel = import.Import(sourceOptions);
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }

        #endregion
    }
}