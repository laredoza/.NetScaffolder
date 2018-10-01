// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericAdoSourceTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    #region Usings

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.SqlServer;
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
            SqlServerAdoSourceType import = new SqlServerAdoSourceType();
            this.SourceType = import;
            var options = new AdoSourceOptions();
            options.ConnectionString = @"Data Source=.\SQLEXPRESS2017;Integrated Security=true;Initial Catalog=AutoNLayered";
            options.Schemas.Add("dbo");
            DatabaseModel databaseModel = import.Import(options);
            
            this.BaseSourceTypeUnitTest_TestValues(databaseModel);
        }

        #endregion
    }
}