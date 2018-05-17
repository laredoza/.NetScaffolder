
// <copyright file="Cedant.g.cs" company="MIT">
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
	/// The CedantRepository class responsible for database functions in the Cedant table
	/// </summary>
	public partial class CedantRepository : UowRepository<Cedant> , ICedantRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Cedant entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedant</returns>
		public virtual ICedant LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Cedant>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.Stamp == stamp).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.UserName == username).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.Name == name).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the TimeLimit field
        /// </summary>
        /// <param name="timelimit">Nullable<long></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByTimeLimit(Nullable<long> timelimit)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.TimeLimit == timelimit).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the isChangeLimited field
        /// </summary>
        /// <param name="ischangelimited">Nullable<bool></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByisChangeLimited(Nullable<bool> ischangelimited)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.isChangeLimited == ischangelimited).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByRemainingChanges(Nullable<int> remainingchanges)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.RemainingChanges == remainingchanges).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the LimitInternetUserOnly field
        /// </summary>
        /// <param name="limitinternetuseronly">Nullable<bool></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByLimitInternetUserOnly(Nullable<bool> limitinternetuseronly)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.LimitInternetUserOnly == limitinternetuseronly).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the BannerImage field
        /// </summary>
        /// <param name="bannerimage">byte[]</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByBannerImage(byte[] bannerimage)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.BannerImage == bannerimage).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the BannerImageType field
        /// </summary>
        /// <param name="bannerimagetype">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByBannerImageType(string bannerimagetype)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.BannerImageType == bannerimagetype).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the TermsConditions field
        /// </summary>
        /// <param name="termsconditions">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByTermsConditions(string termsconditions)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.TermsConditions == termsconditions).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the ReportName field
        /// </summary>
        /// <param name="reportname">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByReportName(string reportname)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.ReportName == reportname).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the License field
        /// </summary>
        /// <param name="license">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByLicense(string license)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.License == license).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the Validator field
        /// </summary>
        /// <param name="validator">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByValidator(string validator)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.Validator == validator).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the LicenseKey field
        /// </summary>
        /// <param name="licensekey">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByLicenseKey(string licensekey)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseKey == licensekey).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the LicenseSalt field
        /// </summary>
        /// <param name="licensesalt">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByLicenseSalt(string licensesalt)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseSalt == licensesalt).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the CedantUniqueIdentifier field
        /// </summary>
        /// <param name="cedantuniqueidentifier">Nullable<Guid></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByCedantUniqueIdentifier(Nullable<Guid> cedantuniqueidentifier)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.CedantUniqueIdentifier == cedantuniqueidentifier).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the ExclusionSetupTableName field
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByExclusionSetupTableName(string exclusionsetuptablename)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.ExclusionSetupTableName == exclusionsetuptablename).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the PostponementSetupTableName field
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByPostponementSetupTableName(string postponementsetuptablename)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.PostponementSetupTableName == postponementsetuptablename).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.QuestionnaireProfileVersionId == questionnaireprofileversionid).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load Cedant entities from the database using the LoadingUrl field
        /// </summary>
        /// <param name="loadingurl">string</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadByLoadingUrl(string loadingurl)
		{
			return this.UnitOfWork.AllMatching<Cedant>(o => o.LoadingUrl == loadingurl).ToList<ICedant>();
		}
		
        /// <summary>
        /// Load all Cedant entities from the database.
        /// </summary>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> LoadAll()
		{
			return this.UnitOfWork.GetAll<Cedant>().ToList<ICedant>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Cedant entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.UserName.Contains(username)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.Name.Contains(name)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by BannerImageType
        /// </summary>
        /// <param name="bannerimagetype">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByBannerImageType(string bannerimagetype, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.BannerImageType.ToLower().Contains(bannerimagetype.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.BannerImageType.Contains(bannerimagetype)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by TermsConditions
        /// </summary>
        /// <param name="termsconditions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByTermsConditions(string termsconditions, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.TermsConditions.ToLower().Contains(termsconditions.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.TermsConditions.Contains(termsconditions)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by ReportName
        /// </summary>
        /// <param name="reportname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByReportName(string reportname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.ReportName.ToLower().Contains(reportname.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.ReportName.Contains(reportname)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by License
        /// </summary>
        /// <param name="license">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByLicense(string license, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.License.ToLower().Contains(license.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.License.Contains(license)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by Validator
        /// </summary>
        /// <param name="validator">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByValidator(string validator, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.Validator.ToLower().Contains(validator.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.Validator.Contains(validator)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by LicenseKey
        /// </summary>
        /// <param name="licensekey">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByLicenseKey(string licensekey, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseKey.ToLower().Contains(licensekey.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseKey.Contains(licensekey)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by LicenseSalt
        /// </summary>
        /// <param name="licensesalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByLicenseSalt(string licensesalt, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseSalt.ToLower().Contains(licensesalt.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LicenseSalt.Contains(licensesalt)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by ExclusionSetupTableName
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByExclusionSetupTableName(string exclusionsetuptablename, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.ExclusionSetupTableName.ToLower().Contains(exclusionsetuptablename.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.ExclusionSetupTableName.Contains(exclusionsetuptablename)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by PostponementSetupTableName
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByPostponementSetupTableName(string postponementsetuptablename, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.PostponementSetupTableName.ToLower().Contains(postponementsetuptablename.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.PostponementSetupTableName.Contains(postponementsetuptablename)).ToList<ICedant>();
			}
		}
		
        /// <summary>
        /// Search for Cedant entities in the database by LoadingUrl
        /// </summary>
        /// <param name="loadingurl">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		public virtual IList<ICedant> SearchByLoadingUrl(string loadingurl, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LoadingUrl.ToLower().Contains(loadingurl.ToLower())).ToList<ICedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant>(o => o.LoadingUrl.Contains(loadingurl)).ToList<ICedant>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Cedant entity to the database.
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedant entity)
		{
			var entityToSave = new Cedant(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Cedant entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedant entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Cedant>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Cedant entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.TimeLimit != entity.TimeLimit) { entityToUpdate.TimeLimit = entity.TimeLimit;doUpdate = true; }
			if (entityToUpdate.isChangeLimited != entity.isChangeLimited) { entityToUpdate.isChangeLimited = entity.isChangeLimited;doUpdate = true; }
			if (entityToUpdate.RemainingChanges != entity.RemainingChanges) { entityToUpdate.RemainingChanges = entity.RemainingChanges;doUpdate = true; }
			if (entityToUpdate.LimitInternetUserOnly != entity.LimitInternetUserOnly) { entityToUpdate.LimitInternetUserOnly = entity.LimitInternetUserOnly;doUpdate = true; }
			if (entityToUpdate.BannerImage != entity.BannerImage) { entityToUpdate.BannerImage = entity.BannerImage;doUpdate = true; }
			if (entityToUpdate.BannerImageType != entity.BannerImageType) { entityToUpdate.BannerImageType = entity.BannerImageType;doUpdate = true; }
			if (entityToUpdate.TermsConditions != entity.TermsConditions) { entityToUpdate.TermsConditions = entity.TermsConditions;doUpdate = true; }
			if (entityToUpdate.ReportName != entity.ReportName) { entityToUpdate.ReportName = entity.ReportName;doUpdate = true; }
			if (entityToUpdate.License != entity.License) { entityToUpdate.License = entity.License;doUpdate = true; }
			if (entityToUpdate.Validator != entity.Validator) { entityToUpdate.Validator = entity.Validator;doUpdate = true; }
			if (entityToUpdate.LicenseKey != entity.LicenseKey) { entityToUpdate.LicenseKey = entity.LicenseKey;doUpdate = true; }
			if (entityToUpdate.LicenseSalt != entity.LicenseSalt) { entityToUpdate.LicenseSalt = entity.LicenseSalt;doUpdate = true; }
			if (entityToUpdate.CedantUniqueIdentifier != entity.CedantUniqueIdentifier) { entityToUpdate.CedantUniqueIdentifier = entity.CedantUniqueIdentifier;doUpdate = true; }
			if (entityToUpdate.ExclusionSetupTableName != entity.ExclusionSetupTableName) { entityToUpdate.ExclusionSetupTableName = entity.ExclusionSetupTableName;doUpdate = true; }
			if (entityToUpdate.PostponementSetupTableName != entity.PostponementSetupTableName) { entityToUpdate.PostponementSetupTableName = entity.PostponementSetupTableName;doUpdate = true; }
			if (entityToUpdate.QuestionnaireProfileVersionId != entity.QuestionnaireProfileVersionId) { entityToUpdate.QuestionnaireProfileVersionId = entity.QuestionnaireProfileVersionId;doUpdate = true; }
			if (entityToUpdate.LoadingUrl != entity.LoadingUrl) { entityToUpdate.LoadingUrl = entity.LoadingUrl;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Cedant entity from the database
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedant entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Cedant>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Cedant entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Cedant entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Cedant>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Cedant entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
