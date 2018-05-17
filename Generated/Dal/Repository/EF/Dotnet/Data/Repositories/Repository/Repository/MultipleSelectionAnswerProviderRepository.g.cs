
// <copyright file="MultipleSelectionAnswerProvider.g.cs" company="MIT">
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
	/// The MultipleSelectionAnswerProviderRepository class responsible for database functions in the MultipleSelectionAnswerProvider table
	/// </summary>
	public partial class MultipleSelectionAnswerProviderRepository : UowRepository<MultipleSelectionAnswerProvider> , IMultipleSelectionAnswerProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for MultipleSelectionAnswerProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public MultipleSelectionAnswerProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the MultipleSelectionAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IMultipleSelectionAnswerProvider</returns>
		public virtual IMultipleSelectionAnswerProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<MultipleSelectionAnswerProvider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the SetupTableID field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		public virtual IList<IMultipleSelectionAnswerProvider> LoadBySetupTableID(Nullable<int> setuptableid)
		{
			return this.UnitOfWork.AllMatching<MultipleSelectionAnswerProvider>(o => o.SetupTableID == setuptableid).ToList<IMultipleSelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the AutoComplete field
        /// </summary>
        /// <param name="autocomplete">Nullable<int></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		public virtual IList<IMultipleSelectionAnswerProvider> LoadByAutoComplete(Nullable<int> autocomplete)
		{
			return this.UnitOfWork.AllMatching<MultipleSelectionAnswerProvider>(o => o.AutoComplete == autocomplete).ToList<IMultipleSelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the UseSynonyms field
        /// </summary>
        /// <param name="usesynonyms">Nullable<bool></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		public virtual IList<IMultipleSelectionAnswerProvider> LoadByUseSynonyms(Nullable<bool> usesynonyms)
		{
			return this.UnitOfWork.AllMatching<MultipleSelectionAnswerProvider>(o => o.UseSynonyms == usesynonyms).ToList<IMultipleSelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the StartsWith field
        /// </summary>
        /// <param name="startswith">Nullable<bool></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		public virtual IList<IMultipleSelectionAnswerProvider> LoadByStartsWith(Nullable<bool> startswith)
		{
			return this.UnitOfWork.AllMatching<MultipleSelectionAnswerProvider>(o => o.StartsWith == startswith).ToList<IMultipleSelectionAnswerProvider>();
		}
		
        /// <summary>
        /// Load all MultipleSelectionAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		public virtual IList<IMultipleSelectionAnswerProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<MultipleSelectionAnswerProvider>().ToList<IMultipleSelectionAnswerProvider>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the MultipleSelectionAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(IMultipleSelectionAnswerProvider entity)
		{
			var entityToSave = new MultipleSelectionAnswerProvider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the MultipleSelectionAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(IMultipleSelectionAnswerProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<MultipleSelectionAnswerProvider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The MultipleSelectionAnswerProvider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.SetupTableID != entity.SetupTableID) { entityToUpdate.SetupTableID = entity.SetupTableID;doUpdate = true; }
			if (entityToUpdate.AutoComplete != entity.AutoComplete) { entityToUpdate.AutoComplete = entity.AutoComplete;doUpdate = true; }
			if (entityToUpdate.UseSynonyms != entity.UseSynonyms) { entityToUpdate.UseSynonyms = entity.UseSynonyms;doUpdate = true; }
			if (entityToUpdate.StartsWith != entity.StartsWith) { entityToUpdate.StartsWith = entity.StartsWith;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the MultipleSelectionAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IMultipleSelectionAnswerProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MultipleSelectionAnswerProvider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MultipleSelectionAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the MultipleSelectionAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MultipleSelectionAnswerProvider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MultipleSelectionAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
