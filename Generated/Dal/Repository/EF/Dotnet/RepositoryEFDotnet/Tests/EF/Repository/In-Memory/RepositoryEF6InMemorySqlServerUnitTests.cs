// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EF;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEF6InMemorySqlServerUnitTest : BaseRepositoryUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public void RunAll()
        {
            string dbId = "EFRepoTest";

            this.AddTests(dbId);
            this.UpdateTests(dbId);
            this.LoadAllTests(dbId);
            this.LoadByIdTests(dbId);
            this.SearchTests(dbId);
        }

        #endregion

        #region Other Methods

        private void SearchTests(string dbId)
        {
            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_SearchByCountryName(uow, "Country");
                this.Country_SearchByCountryName(uow, "Country", false);

                this.Customer_SearchByAddress(uow, "Address");
                this.Customer_SearchByAddress(uow, "Address", false);
                this.Customer_SearchByCity(uow, "City");
                this.Customer_SearchByCity(uow, "City", false);
                this.Customer_SearchByCompanyName(uow, "Company");
                this.Customer_SearchByCompanyName(uow, "Company", false);
                this.Customer_SearchByContactName(uow, "Contact");
                this.Customer_SearchByContactName(uow, "Contact", false);
                this.Customer_SearchByContactTitle(uow, "Title");
                this.Customer_SearchByContactTitle(uow, "Title", false);
                this.Customer_SearchByCustomerCode(uow, "new");
                this.Customer_SearchByCustomerCode(uow, "New", false);
                this.Customer_SearchByFax(uow, "Fax");
                this.Customer_SearchByFax(uow, "Fax", false);
                this.Customer_SearchByPhoto(uow, "Photo");
                this.Customer_SearchByPhoto(uow, "Photo", false);
                this.Customer_SearchByPostalCode(uow, "Postal");
                this.Customer_SearchByPostalCode(uow, "Postal", false);
                this.Customer_SearchByTelephone(uow, "Tel");
                this.Customer_SearchByTelephone(uow, "Tel", false);

                this.Product_SearchByProductDescription(uow, "Product");
                this.Product_SearchByProductDescription(uow, "Product", false);
                this.Product_SearchByPublisher(uow, "Publisher");
                this.Product_SearchByPublisher(uow, "Publisher", false);
                this.Product_SearchByUnitAmount(uow, "1");
                this.Product_SearchByUnitAmount(uow, "1", false);

                this.Book_SearchByPublisher(uow, "Publishder");
                this.Book_SearchByPublisher(uow, "Publishder", false);

                this.Software_SearchByLicenseCode(uow, "License Code");
                this.Software_SearchByLicenseCode(uow, "License Code", false);

                this.Order_SearchByShippingAddress(uow, "Address");
                this.Order_SearchByShippingAddress(uow, "Address", false);
                this.Order_SearchByShippingCity(uow, "City");
                this.Order_SearchByShippingCity(uow, "City", false);
                this.Order_SearchByShippingName(uow, "Shipping");
                this.Order_SearchByShippingName(uow, "Shipping", false);
                this.Order_SearchByShippingZip(uow, "Zip");
                this.Order_SearchByShippingZip(uow, "Zip", false);

                this.BankAccount_SearchByBankAccountNumber(uow, "123");
                this.BankAccount_SearchByBankAccountNumber(uow, "123", false);
            }
        }

        private void LoadByIdTests(string dbId)
        {
            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Customer_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Product_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Book_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Software_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Order_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.OrderDetails_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankAccount_LoadById(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankTransfers_LoadById(uow);
            }
        }

        private void LoadAllTests(string dbId)
        {
            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Customer_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Product_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Book_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Software_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Order_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.OrderDetails_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankAccount_LoadAll(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankTransfers_LoadAll(uow);
            }
        }

        /// <summary>
        /// The add tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void AddTests(string dbId)
        {
            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_Add(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Book_Add(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankTransfers_Add(uow);
            }
        }

        /// <summary>
        /// The update tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void UpdateTests(string dbId)
        {
            // Updates
            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Customer_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Product_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Book_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Software_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Order_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.OrderDetails_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankAccount_Update(uow);
            }

            using (var uow = new SqlServerFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankTransfers_Update(uow);
            }
        }

        #endregion
    }
}