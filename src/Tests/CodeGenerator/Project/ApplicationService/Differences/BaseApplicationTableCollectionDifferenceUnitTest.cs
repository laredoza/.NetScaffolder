﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseApplicationTableCollectionDifferenceUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Project.ApplicationService.Differences
{
    #region Usings

    using System.Linq;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The base application table collection difference unit test.
    /// </summary>
    [TestClass]
    public class BaseApplicationTableCollectionDifferenceUnitTest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the difference.
        /// </summary>
        public IApplicationTableCollectionDifference Differences { get; set; }

        /// <summary>
        ///     Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The base application table collection difference unit test_ run tests.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        [TestMethod]
        public void BaseApplicationTableCollectionDifferenceUnitTest_RunTests(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            this.TestNodifference(
                originalDatabaseModel,
                changedDatabaseModel);

            this.RemoveTableFromChangedModel(
                originalDatabaseModel,
                changedDatabaseModel);

            this.RemoveColumn(
                originalDatabaseModel,
                changedDatabaseModel);
            
            this.UpdateColumn(
                originalDatabaseModel,
                changedDatabaseModel);

            this.AddTableToSource(
                originalDatabaseModel,
                changedDatabaseModel);
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The base application table collection difference unit test_ remove column.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        private void RemoveColumn(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            Table bankTransfers = changedDatabaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers");
            Column bankTransfersIdColumn = bankTransfers.Columns.FirstOrDefault(c => c.ColumnName == "BankTransferId");
            bankTransfers.Columns.Remove(bankTransfersIdColumn);

            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);

            Assert.AreEqual(0, differences.FirstExtraTables.Count, "There should be 0 Extra tables");
            Assert.AreEqual(0, differences.FirstMissingTables.Count, "There should be 0 missing tables");
            Assert.AreEqual(1, differences.ProblemTables.Count, "There should be 1 problem tables");
            Assert.AreEqual(1, differences.RefreshTable.Count, "There should be 1 table to refresh");

            Assert.AreEqual(1, differences.ProblemTables[0].FirstExtraColumns.Count);
            Assert.AreEqual("BankTransferId", differences.ProblemTables[0].FirstExtraColumns[0].ColumnName);

            Assert.AreEqual("BankTransfers", differences.RefreshTable[0].TableName);

            bankTransfers.Columns.Insert(0, bankTransfersIdColumn);
        }

        /// <summary>
        /// The base application table collection difference unit test_ add table to source.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        private void AddTableToSource(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            Table bankTransfers = originalDatabaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers");
            originalDatabaseModel.Tables.Remove(bankTransfers);

            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);

            Assert.AreEqual(1, differences.FirstExtraTables.Count, "There should be 1 Extra tables");
            Assert.AreEqual(0, differences.FirstMissingTables.Count, "There should be 0 missing tables");
            Assert.AreEqual(0, differences.ProblemTables.Count, "There should be 0 problem tables");
            Assert.AreEqual(0, differences.RefreshTable.Count, "There should be 0 refresh tables");

            Assert.AreEqual("BankTransfers", differences.FirstExtraTables[0].TableName);

            originalDatabaseModel.Tables.Insert(0, bankTransfers);
        }

        /// <summary>
        /// The remove table from changed model.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        private void RemoveTableFromChangedModel(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            Table bankTransfers = changedDatabaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers");
            changedDatabaseModel.Tables.Remove(bankTransfers);

            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);

            Assert.AreEqual(0, differences.FirstExtraTables.Count, "There should be 0 Extra tables");
            Assert.AreEqual(1, differences.FirstMissingTables.Count, "There should be 1 missing table");
            Assert.AreEqual(0, differences.ProblemTables.Count, "There should be 0 problem tables");
            Assert.AreEqual(0, differences.RefreshTable.Count, "There should be 0 refresh tables");

            changedDatabaseModel.Tables.Insert(0, bankTransfers);
        }

        /// <summary>
        /// The test nodifference.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        private void TestNodifference(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);
            Assert.AreEqual(0, differences.FirstExtraTables.Count, "There should be 0 Extra tables");
            Assert.AreEqual(0, differences.FirstMissingTables.Count, "There should be 0 missing tables");
            Assert.AreEqual(0, differences.ProblemTables.Count, "There should be 0 problem tables");
            Assert.AreEqual(0, differences.RefreshTable.Count, "There should be 0 refresh tables");
        }

        /// <summary>
        /// The update column.
        /// </summary>
        /// <param name="originalDatabaseModel">
        /// The original database model.
        /// </param>
        /// <param name="changedDatabaseModel">
        /// The changed database model.
        /// </param>
        private void UpdateColumn(
            DatabaseModel originalDatabaseModel,
            DatabaseModel changedDatabaseModel)
        {
            Table bankTransfers = changedDatabaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers");
            Column bankTransfersIdColumn = bankTransfers.Columns.FirstOrDefault(c => c.ColumnName == "BankTransferId");

            // Test DomainType
            bankTransfersIdColumn.DomainDataType = DomainDataType.Boolean;

            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);
            Assert.AreEqual(
                DomainDataType.Int32,
                differences.ProblemTables[0].ColumnDataTypeDiffs[0].FirstColumnDataType);
            Assert.AreEqual(
                DomainDataType.Boolean,
                differences.ProblemTables[0].ColumnDataTypeDiffs[0].SecondColumnDataType);

            bankTransfersIdColumn.DomainDataType = DomainDataType.Int32;

            // Test ColumnOrder
            bankTransfersIdColumn.ColumnOrder = 3;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].ColumnOrderIsDifferent);
            bankTransfersIdColumn.ColumnOrder = 1;

            // Test IsPrimaryKey
            bankTransfersIdColumn.IsPrimaryKey = false;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].PrimaryKeyIsDifferent);
            bankTransfersIdColumn.IsPrimaryKey = true;

            // Test IsRequired
            bankTransfersIdColumn.IsRequired = false;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].IsRequiredDifferent);
            bankTransfersIdColumn.IsRequired = true;

            // Test Length
            bankTransfersIdColumn.Length = 1;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].LengthIsDifferent);
            bankTransfersIdColumn.Length = 0;

            // Test Precision
            bankTransfersIdColumn.Precision = 1;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].PrecisionIsDifferent);
            bankTransfersIdColumn.Precision = 0;

            // Test Scale 
            bankTransfersIdColumn.Scale = 1;

            differences = this.Differences.CompareTables(originalDatabaseModel.Tables, changedDatabaseModel.Tables);

            this.SharedColumnChanged(differences);

            Assert.AreEqual(true, differences.ProblemTables[0].ColumnDataTypeDiffs[0].ScaleIsDifferent);
            bankTransfersIdColumn.Scale = 0;
        }

        /// <summary>
        /// The shared column changed.
        /// </summary>
        /// <param name="differences">
        /// The differences.
        /// </param>
        private void SharedColumnChanged(ApplicationTableCollectionDifference differences)
        {
            Assert.AreEqual(0, differences.FirstExtraTables.Count, "There should be 0 Extra tables");
            Assert.AreEqual(0, differences.FirstMissingTables.Count, "There should be 0 missing tables");
            Assert.AreEqual(1, differences.ProblemTables.Count, "There should be 1 problem tables");
            Assert.AreEqual(1, differences.RefreshTable.Count, "There should be 1 table to refresh");

            Assert.AreEqual(1, differences.ProblemTables[0].ColumnDataTypeDiffs.Count);

            Assert.AreEqual(
                "BankTransferId",
                differences.ProblemTables[0].ColumnDataTypeDiffs[0].FirstColumn.ColumnName);
            Assert.AreEqual("BankTransfers", differences.RefreshTable[0].TableName);
        }

        #endregion
    }
}