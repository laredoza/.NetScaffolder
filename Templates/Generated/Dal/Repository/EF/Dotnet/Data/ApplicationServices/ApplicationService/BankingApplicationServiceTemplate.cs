using Banking.Models.Interfaces;
using Banking.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class BankingApplicationServiceTemplate
    {
        protected BankAccountRepository bankAccountRepository { get; set; }

        public BankingApplicationServiceTemplate(BankAccountRepository bankAccountRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
        }

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the composite primary keys
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>IBankAccount</returns>
        public virtual IBankAccount BankAccountLoadByBankAccountId(int bankAccountId)
        {
            return this.bankAccountRepository.LoadByBankAccountId(bankAccountId);
        }

        /// <summary>
        /// Load BankAccount entities from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> BankAccountLoadByBalance(decimal balance)
        {
            return this.bankAccountRepository.LoadByBalance(balance);
        }

        /// <summary>
        /// Load BankAccount entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> BankAccountLoadByCustomerId(Nullable<int> customerId)
        {
            return this.bankAccountRepository.LoadByCustomerId(customerId);
        }

        /// <summary>
        /// Load BankAccount entities from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> BankAccountLoadByLocked(bool locked)
        {
            return this.bankAccountRepository.LoadByLocked(locked);
        }

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> BankAccountLoadAll()
        {
            return this.bankAccountRepository.LoadAll();
        }

        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
        /// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
        public virtual IList<IBankAccount> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive = false)
        {
            return this.bankAccountRepository.SearchByBankAccountNumber(bankAccountNumber, caseSensitive);
        }

        #endregion

        #region Modifiers

        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
        public virtual bool BankAccountSave(IBankAccount entity)
        {
            return this.bankAccountRepository.Save(entity);
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool BankAccountUpdate(IBankAccount entity)
        {
            return this.bankAccountRepository.Update(entity);
        }

        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
        public virtual bool BankAccountDelete(IBankAccount entity)
        {
            return this.bankAccountRepository.Delete(entity);
        }

        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
        public virtual bool BankAccountDelete(int bankAccountId)
        {
            return this.bankAccountRepository.Delete(bankAccountId);
        }

        #endregion

    }
}
