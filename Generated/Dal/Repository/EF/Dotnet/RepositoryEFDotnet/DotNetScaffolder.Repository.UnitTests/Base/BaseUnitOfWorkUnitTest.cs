// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseUnitOfWorkUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Banking.Models.Entity;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The base unit of work unit tests.
    /// </summary>
    /// <typeparam name="TUow">
    /// </typeparam>
    public abstract partial class BaseUnitOfWorkUnitTests<TUow>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The base unit of work unit tests_ bank transfers_ first or default_ includes.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankTransfers_FirstOrDefault_Includes()
        {
            var bankTransfer = new BankTransfers();
            this.PopulateBankTransfers(bankTransfer);
            Uow.Add(bankTransfer);
            Uow.Commit();

            var savedEntity = Uow.FirstOrDefault<BankTransfers>(null, new List<string> { "BankAccount" });
            Assert.IsNotNull(savedEntity, "Could not find BankTransfer");

            Assert.IsNotNull(savedEntity.BankAccountFrom, "Could not find BankTransfer.BankAccountFrom");
            Assert.AreEqual(
                bankTransfer.FromBankAccountId,
                savedEntity.BankAccountFrom.BankAccountId,
                "Incorrect BankTranfer.BankAccountFrom.BankAccountId");

            Assert.IsNotNull(savedEntity.BankAccountTo, "Could not find BankTransfer.BankAccountTo");
            Assert.AreEqual(
                bankTransfer.ToBankAccountId,
                savedEntity.BankAccountTo.BankAccountId,
                "Incorrect BankTranfer.BankAccountTo.BankAccountId");
        }

        #endregion
    }
}