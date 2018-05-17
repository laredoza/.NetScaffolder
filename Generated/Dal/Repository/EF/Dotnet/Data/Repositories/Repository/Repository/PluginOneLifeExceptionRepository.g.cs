
// <copyright file="PluginOneLifeException.g.cs" company="MIT">
//  Copyright (c) 2018 MIT
// </copyright>  

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.


// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The PluginOneLifeExceptionRepository class responsible for database functions in the PluginOneLifeException table
	/// </summary>
	public partial class PluginOneLifeExceptionRepository : UowRepository<PluginOneLifeException> , IPluginOneLifeExceptionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeExceptionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeExceptionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeException entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeException</returns>
		public virtual IPluginOneLifeException LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeException>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.Stamp == stamp).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.UserName == username).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the PluginOneLifePolicyId field
        /// </summary>
        /// <param name="pluginonelifepolicyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByPluginOneLifePolicyId(Nullable<int> pluginonelifepolicyid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.PluginOneLifePolicyId == pluginonelifepolicyid).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the ProductName field
        /// </summary>
        /// <param name="productname">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByProductName(string productname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductName == productname).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the ProductResult field
        /// </summary>
        /// <param name="productresult">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByProductResult(string productresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductResult == productresult).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the QUIRCProductName field
        /// </summary>
        /// <param name="quircproductname">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByQUIRCProductName(string quircproductname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductName == quircproductname).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the QUIRCProductResult field
        /// </summary>
        /// <param name="quircproductresult">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByQUIRCProductResult(string quircproductresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductResult == quircproductresult).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByMessage(string message)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.Message == message).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the PolicyResult field
        /// </summary>
        /// <param name="policyresult">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByPolicyResult(string policyresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.PolicyResult == policyresult).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the ProductLoading field
        /// </summary>
        /// <param name="productloading">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByProductLoading(string productloading)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductLoading == productloading).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the ProductReferences field
        /// </summary>
        /// <param name="productreferences">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByProductReferences(string productreferences)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductReferences == productreferences).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the QUIRCPolicyResult field
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByQUIRCPolicyResult(string quircpolicyresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCPolicyResult == quircpolicyresult).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the QUIRCProductLoading field
        /// </summary>
        /// <param name="quircproductloading">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByQUIRCProductLoading(string quircproductloading)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductLoading == quircproductloading).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeException entities from the database using the QUIRCProductReferences field
        /// </summary>
        /// <param name="quircproductreferences">string</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadByQUIRCProductReferences(string quircproductreferences)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductReferences == quircproductreferences).ToList<IPluginOneLifeException>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeException entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeException>().ToList<IPluginOneLifeException>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by ProductName
        /// </summary>
        /// <param name="productname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByProductName(string productname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductName.ToLower().Contains(productname.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductName.Contains(productname)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by ProductResult
        /// </summary>
        /// <param name="productresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByProductResult(string productresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductResult.ToLower().Contains(productresult.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductResult.Contains(productresult)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by QUIRCProductName
        /// </summary>
        /// <param name="quircproductname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByQUIRCProductName(string quircproductname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductName.ToLower().Contains(quircproductname.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductName.Contains(quircproductname)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by QUIRCProductResult
        /// </summary>
        /// <param name="quircproductresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByQUIRCProductResult(string quircproductresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductResult.ToLower().Contains(quircproductresult.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductResult.Contains(quircproductresult)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByMessage(string message, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.Message.ToLower().Contains(message.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.Message.Contains(message)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by PolicyResult
        /// </summary>
        /// <param name="policyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByPolicyResult(string policyresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.PolicyResult.ToLower().Contains(policyresult.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.PolicyResult.Contains(policyresult)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by ProductLoading
        /// </summary>
        /// <param name="productloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByProductLoading(string productloading, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductLoading.ToLower().Contains(productloading.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductLoading.Contains(productloading)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by ProductReferences
        /// </summary>
        /// <param name="productreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByProductReferences(string productreferences, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductReferences.ToLower().Contains(productreferences.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.ProductReferences.Contains(productreferences)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by QUIRCPolicyResult
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByQUIRCPolicyResult(string quircpolicyresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCPolicyResult.ToLower().Contains(quircpolicyresult.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCPolicyResult.Contains(quircpolicyresult)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by QUIRCProductLoading
        /// </summary>
        /// <param name="quircproductloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByQUIRCProductLoading(string quircproductloading, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductLoading.ToLower().Contains(quircproductloading.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductLoading.Contains(quircproductloading)).ToList<IPluginOneLifeException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeException entities in the database by QUIRCProductReferences
        /// </summary>
        /// <param name="quircproductreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeException></returns>
		public virtual IList<IPluginOneLifeException> SearchByQUIRCProductReferences(string quircproductreferences, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductReferences.ToLower().Contains(quircproductreferences.ToLower())).ToList<IPluginOneLifeException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeException>(o => o.QUIRCProductReferences.Contains(quircproductreferences)).ToList<IPluginOneLifeException>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeException entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeException</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeException entity)
		{
			var entityToSave = new PluginOneLifeException(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeException entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeException</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeException entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeException>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeException entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifePolicyId != entity.PluginOneLifePolicyId) { entityToUpdate.PluginOneLifePolicyId = entity.PluginOneLifePolicyId;doUpdate = true; }
			if (entityToUpdate.ProductName != entity.ProductName) { entityToUpdate.ProductName = entity.ProductName;doUpdate = true; }
			if (entityToUpdate.ProductResult != entity.ProductResult) { entityToUpdate.ProductResult = entity.ProductResult;doUpdate = true; }
			if (entityToUpdate.QUIRCProductName != entity.QUIRCProductName) { entityToUpdate.QUIRCProductName = entity.QUIRCProductName;doUpdate = true; }
			if (entityToUpdate.QUIRCProductResult != entity.QUIRCProductResult) { entityToUpdate.QUIRCProductResult = entity.QUIRCProductResult;doUpdate = true; }
			if (entityToUpdate.Message != entity.Message) { entityToUpdate.Message = entity.Message;doUpdate = true; }
			if (entityToUpdate.PolicyResult != entity.PolicyResult) { entityToUpdate.PolicyResult = entity.PolicyResult;doUpdate = true; }
			if (entityToUpdate.ProductLoading != entity.ProductLoading) { entityToUpdate.ProductLoading = entity.ProductLoading;doUpdate = true; }
			if (entityToUpdate.ProductReferences != entity.ProductReferences) { entityToUpdate.ProductReferences = entity.ProductReferences;doUpdate = true; }
			if (entityToUpdate.QUIRCPolicyResult != entity.QUIRCPolicyResult) { entityToUpdate.QUIRCPolicyResult = entity.QUIRCPolicyResult;doUpdate = true; }
			if (entityToUpdate.QUIRCProductLoading != entity.QUIRCProductLoading) { entityToUpdate.QUIRCProductLoading = entity.QUIRCProductLoading;doUpdate = true; }
			if (entityToUpdate.QUIRCProductReferences != entity.QUIRCProductReferences) { entityToUpdate.QUIRCProductReferences = entity.QUIRCProductReferences;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifeException entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeException</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeException entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeException>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeException entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeException entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeException>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeException entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
