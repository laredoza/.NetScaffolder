
// <copyright file="PluginOneLifeBatchRunException.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunExceptionRepository class responsible for database functions in the PluginOneLifeBatchRunException table
	/// </summary>
	public partial class PluginOneLifeBatchRunExceptionRepository : UowRepository<PluginOneLifeBatchRunException> , IPluginOneLifeBatchRunExceptionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeBatchRunExceptionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeBatchRunExceptionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeBatchRunException entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunException</returns>
		public virtual IPluginOneLifeBatchRunException LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunException>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.Stamp == stamp).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.UserName == username).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the PluginOneLifeBatchRunPolicyId field
        /// </summary>
        /// <param name="pluginonelifebatchrunpolicyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByPluginOneLifeBatchRunPolicyId(Nullable<int> pluginonelifebatchrunpolicyid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.PluginOneLifeBatchRunPolicyId == pluginonelifebatchrunpolicyid).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductName field
        /// </summary>
        /// <param name="productname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByProductName(string productname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductName == productname).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductResult field
        /// </summary>
        /// <param name="productresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByProductResult(string productresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductResult == productresult).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductName field
        /// </summary>
        /// <param name="quircproductname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductName(string quircproductname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductName == quircproductname).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductResult field
        /// </summary>
        /// <param name="quircproductresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductResult(string quircproductresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductResult == quircproductresult).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByMessage(string message)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.Message == message).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the PolicyResult field
        /// </summary>
        /// <param name="policyresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByPolicyResult(string policyresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.PolicyResult == policyresult).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductLoading field
        /// </summary>
        /// <param name="productloading">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByProductLoading(string productloading)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductLoading == productloading).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductReferences field
        /// </summary>
        /// <param name="productreferences">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByProductReferences(string productreferences)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductReferences == productreferences).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCPolicyResult field
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByQUIRCPolicyResult(string quircpolicyresult)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCPolicyResult == quircpolicyresult).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductLoading field
        /// </summary>
        /// <param name="quircproductloading">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductLoading(string quircproductloading)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductLoading == quircproductloading).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductReferences field
        /// </summary>
        /// <param name="quircproductreferences">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductReferences(string quircproductreferences)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductReferences == quircproductreferences).ToList<IPluginOneLifeBatchRunException>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeBatchRunException entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeBatchRunException>().ToList<IPluginOneLifeBatchRunException>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductName
        /// </summary>
        /// <param name="productname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByProductName(string productname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductName.ToLower().Contains(productname.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductName.Contains(productname)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductResult
        /// </summary>
        /// <param name="productresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByProductResult(string productresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductResult.ToLower().Contains(productresult.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductResult.Contains(productresult)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductName
        /// </summary>
        /// <param name="quircproductname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductName(string quircproductname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductName.ToLower().Contains(quircproductname.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductName.Contains(quircproductname)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductResult
        /// </summary>
        /// <param name="quircproductresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductResult(string quircproductresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductResult.ToLower().Contains(quircproductresult.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductResult.Contains(quircproductresult)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByMessage(string message, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.Message.ToLower().Contains(message.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.Message.Contains(message)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by PolicyResult
        /// </summary>
        /// <param name="policyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByPolicyResult(string policyresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.PolicyResult.ToLower().Contains(policyresult.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.PolicyResult.Contains(policyresult)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductLoading
        /// </summary>
        /// <param name="productloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByProductLoading(string productloading, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductLoading.ToLower().Contains(productloading.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductLoading.Contains(productloading)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductReferences
        /// </summary>
        /// <param name="productreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByProductReferences(string productreferences, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductReferences.ToLower().Contains(productreferences.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.ProductReferences.Contains(productreferences)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCPolicyResult
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByQUIRCPolicyResult(string quircpolicyresult, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCPolicyResult.ToLower().Contains(quircpolicyresult.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCPolicyResult.Contains(quircpolicyresult)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductLoading
        /// </summary>
        /// <param name="quircproductloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductLoading(string quircproductloading, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductLoading.ToLower().Contains(quircproductloading.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductLoading.Contains(quircproductloading)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductReferences
        /// </summary>
        /// <param name="quircproductreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		public virtual IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductReferences(string quircproductreferences, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductReferences.ToLower().Contains(quircproductreferences.ToLower())).ToList<IPluginOneLifeBatchRunException>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunException>(o => o.QUIRCProductReferences.Contains(quircproductreferences)).ToList<IPluginOneLifeBatchRunException>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunException entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeBatchRunException entity)
		{
			var entityToSave = new PluginOneLifeBatchRunException(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunException entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeBatchRunException entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunException>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeBatchRunException entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeBatchRunPolicyId != entity.PluginOneLifeBatchRunPolicyId) { entityToUpdate.PluginOneLifeBatchRunPolicyId = entity.PluginOneLifeBatchRunPolicyId;doUpdate = true; }
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
        /// Delete the PluginOneLifeBatchRunException entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeBatchRunException entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunException>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunException entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunException entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunException>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunException entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
