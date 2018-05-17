
// <copyright file="ProductReference.g.cs" company="MIT">
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
	/// The ProductReferenceRepository class responsible for database functions in the ProductReference table
	/// </summary>
	public partial class ProductReferenceRepository : UowRepository<ProductReference> , IProductReferenceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductReferenceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductReferenceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductReference</returns>
		public virtual IProductReference LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductReference>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ProductReference entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ProductReference>(o => o.Stamp == stamp).ToList<IProductReference>();
		}
		
        /// <summary>
        /// Load ProductReference entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ProductReference>(o => o.UserName == username).ToList<IProductReference>();
		}
		
        /// <summary>
        /// Load ProductReference entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<ProductReference>(o => o.SetupTableDataId == setuptabledataid).ToList<IProductReference>();
		}
		
        /// <summary>
        /// Load ProductReference entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<ProductReference>(o => o.ProductId == productid).ToList<IProductReference>();
		}
		
        /// <summary>
        /// Load ProductReference entities from the database using the Source field
        /// </summary>
        /// <param name="source">bool</param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadBySource(bool source)
		{
			return this.UnitOfWork.AllMatching<ProductReference>(o => o.Source == source).ToList<IProductReference>();
		}
		
        /// <summary>
        /// Load all ProductReference entities from the database.
        /// </summary>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductReference>().ToList<IProductReference>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductReference entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductReference></returns>
		public virtual IList<IProductReference> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductReference>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProductReference>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductReference>(o => o.UserName.Contains(username)).ToList<IProductReference>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductReference entity to the database.
        /// </summary>
        /// <param name="entity">IProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductReference entity)
		{
			var entityToSave = new ProductReference(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductReference entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductReference>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductReference entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.Source != entity.Source) { entityToUpdate.Source = entity.Source;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductReference entity from the database
        /// </summary>
        /// <param name="entity">IProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductReference entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductReference>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductReference>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
