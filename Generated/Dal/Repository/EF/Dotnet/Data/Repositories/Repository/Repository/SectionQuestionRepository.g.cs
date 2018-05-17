
// <copyright file="SectionQuestion.g.cs" company="MIT">
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
	/// The SectionQuestionRepository class responsible for database functions in the SectionQuestion table
	/// </summary>
	public partial class SectionQuestionRepository : UowRepository<SectionQuestion> , ISectionQuestionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionQuestionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionQuestionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load SectionQuestion entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">int</param>
        /// <returns>IList<ISectionQuestion></returns>
		public virtual IList<ISectionQuestion> LoadBySectionProfileId(int sectionprofileid)
		{
			return this.UnitOfWork.AllMatching<SectionQuestion>(o => o.SectionProfileId == sectionprofileid).ToList<ISectionQuestion>();
		}
		
        /// <summary>
        /// Load SectionQuestion entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">int</param>
        /// <returns>IList<ISectionQuestion></returns>
		public virtual IList<ISectionQuestion> LoadByQuestionProfileId(int questionprofileid)
		{
			return this.UnitOfWork.AllMatching<SectionQuestion>(o => o.QuestionProfileId == questionprofileid).ToList<ISectionQuestion>();
		}
		
        /// <summary>
        /// Load all SectionQuestion entities from the database.
        /// </summary>
        /// <returns>IList<ISectionQuestion></returns>
		public virtual IList<ISectionQuestion> LoadAll()
		{
			return this.UnitOfWork.GetAll<SectionQuestion>().ToList<ISectionQuestion>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionQuestion entity to the database.
        /// </summary>
        /// <param name="entity">ISectionQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISectionQuestion entity)
		{
			var entityToSave = new SectionQuestion(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
		
		#endregion
	}
}
