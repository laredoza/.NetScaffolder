
// <copyright file="SelectionAnswerProvider.g.cs" company="MIT">
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
	/// The SelectionAnswerProviderRepository class responsible for database functions in the SelectionAnswerProvider table
	/// </summary>
	public partial class SelectionAnswerProviderRepository : UowRepository<SelectionAnswerProvider> , ISelectionAnswerProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SelectionAnswerProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SelectionAnswerProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SelectionAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISelectionAnswerProvider</returns>
		public virtual ISelectionAnswerProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SelectionAnswerProvider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the SetupTableId field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadBySetupTableId(Nullable<int> setuptableid)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.SetupTableId == setuptableid).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the WithFilter field
        /// </summary>
        /// <param name="withfilter">Nullable<bool></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadByWithFilter(Nullable<bool> withfilter)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.WithFilter == withfilter).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the WithFilterValue field
        /// </summary>
        /// <param name="withfiltervalue">string</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadByWithFilterValue(string withfiltervalue)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.WithFilterValue == withfiltervalue).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the AutoComplete field
        /// </summary>
        /// <param name="autocomplete">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadByAutoComplete(bool autocomplete)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.AutoComplete == autocomplete).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the StartsWith field
        /// </summary>
        /// <param name="startswith">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadByStartsWith(bool startswith)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.StartsWith == startswith).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the UseSynonyms field
        /// </summary>
        /// <param name="usesynonyms">Nullable<bool></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadByUseSynonyms(Nullable<bool> usesynonyms)
		{
			return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.UseSynonyms == usesynonyms).ToList<ISelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load all SelectionAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<SelectionAnswerProvider>().ToList<ISelectionAnswerProvider>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SelectionAnswerProvider entities in the database by WithFilterValue
        /// </summary>
        /// <param name="withfiltervalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		public virtual IList<ISelectionAnswerProvider> SearchByWithFilterValue(string withfiltervalue, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.WithFilterValue.ToLower().Contains(withfiltervalue.ToLower())).ToList<ISelectionAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SelectionAnswerProvider>(o => o.WithFilterValue.Contains(withfiltervalue)).ToList<ISelectionAnswerProvider>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SelectionAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISelectionAnswerProvider entity)
		{
			var entityToSave = new SelectionAnswerProvider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SelectionAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISelectionAnswerProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SelectionAnswerProvider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SelectionAnswerProvider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.SetupTableId != entity.SetupTableId) { entityToUpdate.SetupTableId = entity.SetupTableId;doUpdate = true; }
			if (entityToUpdate.WithFilter != entity.WithFilter) { entityToUpdate.WithFilter = entity.WithFilter;doUpdate = true; }
			if (entityToUpdate.WithFilterValue != entity.WithFilterValue) { entityToUpdate.WithFilterValue = entity.WithFilterValue;doUpdate = true; }
			if (entityToUpdate.AutoComplete != entity.AutoComplete) { entityToUpdate.AutoComplete = entity.AutoComplete;doUpdate = true; }
			if (entityToUpdate.StartsWith != entity.StartsWith) { entityToUpdate.StartsWith = entity.StartsWith;doUpdate = true; }
			if (entityToUpdate.UseSynonyms != entity.UseSynonyms) { entityToUpdate.UseSynonyms = entity.UseSynonyms;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SelectionAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISelectionAnswerProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SelectionAnswerProvider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SelectionAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SelectionAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SelectionAnswerProvider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SelectionAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
