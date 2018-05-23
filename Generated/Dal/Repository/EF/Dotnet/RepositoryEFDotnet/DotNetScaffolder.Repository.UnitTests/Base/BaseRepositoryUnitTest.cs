// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseRepositoryUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Collections.Generic;
    using System.Linq;

    using Banking.Models.Dto;
    using Banking.Models.Interfaces;
    using Banking.Models.Repository;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The base repository unit test.
    /// </summary>
    public abstract partial class BaseRepositoryUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        /// The bank account_ add range.
        /// </summary>
        /// <param name="expected">
        /// The expected.
        /// </param>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        [TestMethod]
        public void BankAccount_AddRange(int expected, int count = 1, int seed = 1)
        {
            var repo = new BankAccountRepository(Context);
            this.BaseRepositoryUnitTest_BankAccount_AddRange(repo, count, seed, expected);
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public void RunAll()
        {
            this.BankAccount_Add();
            this.BankAccount_AddRange(3, 2, 2);
            this.BankTransfers_Add();
            this.Country_Add();
            this.Customer_Add();
            this.Product_Add();
            this.Book_Add();
            this.Software_Add();
            this.Order_Add();
            this.OrderDetails_Add();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The base repository unit test_ bank account_ add range.
        /// </summary>
        /// <param name="repository">
        /// The repository.
        /// </param>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        /// <param name="expected">
        /// The expected.
        /// </param>
        private void BaseRepositoryUnitTest_BankAccount_AddRange(
            IBankAccountRepository repository,
            int count,
            int seed,
            int expected)
        {
            var newItems = new List<BankAccountDto>();
            for (var index = 0; index < count; index++)
            {
                var dto = new BankAccountDto();
                this.PopulateBankAccount(dto, false, seed);
                repository.Save(dto);
                newItems.Add(dto);
                seed++;
            }

            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            this.Check_EntityCount(expected, result.Count, "BankAccount");

            foreach (var item in newItems)
                this.Check_BankAccount(item, result.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
        }

        #endregion
    }
}