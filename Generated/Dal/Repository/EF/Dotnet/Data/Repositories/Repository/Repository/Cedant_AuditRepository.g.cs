
// <copyright file="Cedant_Audit.g.cs" company="MIT">
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
	/// The Cedant_AuditRepository class responsible for database functions in the Cedant_Audit table
	/// </summary>
	public partial class Cedant_AuditRepository : UowRepository<Cedant_Audit> , ICedant_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Cedant_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Cedant_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Cedant_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedant_Audit</returns>
		public virtual ICedant_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Cedant_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Id == id).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Stamp == stamp).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.UserName == username).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Name == name).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the TimeLimit field
        /// </summary>
        /// <param name="timelimit">Nullable<long></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByTimeLimit(Nullable<long> timelimit)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.TimeLimit == timelimit).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the isChangeLimited field
        /// </summary>
        /// <param name="ischangelimited">Nullable<bool></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByisChangeLimited(Nullable<bool> ischangelimited)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.isChangeLimited == ischangelimited).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByRemainingChanges(Nullable<int> remainingchanges)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.RemainingChanges == remainingchanges).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the LimitInternetUserOnly field
        /// </summary>
        /// <param name="limitinternetuseronly">Nullable<bool></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByLimitInternetUserOnly(Nullable<bool> limitinternetuseronly)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LimitInternetUserOnly == limitinternetuseronly).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the BannerImage field
        /// </summary>
        /// <param name="bannerimage">byte[]</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByBannerImage(byte[] bannerimage)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.BannerImage == bannerimage).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the BannerImageType field
        /// </summary>
        /// <param name="bannerimagetype">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByBannerImageType(string bannerimagetype)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.BannerImageType == bannerimagetype).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the TermsConditions field
        /// </summary>
        /// <param name="termsconditions">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByTermsConditions(string termsconditions)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.TermsConditions == termsconditions).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the ReportName field
        /// </summary>
        /// <param name="reportname">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByReportName(string reportname)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ReportName == reportname).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the License field
        /// </summary>
        /// <param name="license">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByLicense(string license)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.License == license).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the Validator field
        /// </summary>
        /// <param name="validator">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByValidator(string validator)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Validator == validator).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the LicenseKey field
        /// </summary>
        /// <param name="licensekey">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByLicenseKey(string licensekey)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseKey == licensekey).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the LicenseSalt field
        /// </summary>
        /// <param name="licensesalt">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByLicenseSalt(string licensesalt)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseSalt == licensesalt).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the CedantUniqueIdentifier field
        /// </summary>
        /// <param name="cedantuniqueidentifier">Nullable<Guid></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByCedantUniqueIdentifier(Nullable<Guid> cedantuniqueidentifier)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.CedantUniqueIdentifier == cedantuniqueidentifier).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the ExclusionSetupTableName field
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByExclusionSetupTableName(string exclusionsetuptablename)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ExclusionSetupTableName == exclusionsetuptablename).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the PostponementSetupTableName field
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByPostponementSetupTableName(string postponementsetuptablename)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.PostponementSetupTableName == postponementsetuptablename).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.QuestionnaireProfileVersionId == questionnaireprofileversionid).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load Cedant_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICedant_Audit>();
		}
		
        /// <summary>
        /// Load all Cedant_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Cedant_Audit>().ToList<ICedant_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.UserName.Contains(username)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Name.Contains(name)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by BannerImageType
        /// </summary>
        /// <param name="bannerimagetype">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByBannerImageType(string bannerimagetype, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.BannerImageType.ToLower().Contains(bannerimagetype.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.BannerImageType.Contains(bannerimagetype)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by TermsConditions
        /// </summary>
        /// <param name="termsconditions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByTermsConditions(string termsconditions, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.TermsConditions.ToLower().Contains(termsconditions.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.TermsConditions.Contains(termsconditions)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by ReportName
        /// </summary>
        /// <param name="reportname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByReportName(string reportname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ReportName.ToLower().Contains(reportname.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ReportName.Contains(reportname)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by License
        /// </summary>
        /// <param name="license">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByLicense(string license, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.License.ToLower().Contains(license.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.License.Contains(license)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by Validator
        /// </summary>
        /// <param name="validator">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByValidator(string validator, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Validator.ToLower().Contains(validator.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.Validator.Contains(validator)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by LicenseKey
        /// </summary>
        /// <param name="licensekey">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByLicenseKey(string licensekey, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseKey.ToLower().Contains(licensekey.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseKey.Contains(licensekey)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by LicenseSalt
        /// </summary>
        /// <param name="licensesalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByLicenseSalt(string licensesalt, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseSalt.ToLower().Contains(licensesalt.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.LicenseSalt.Contains(licensesalt)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by ExclusionSetupTableName
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByExclusionSetupTableName(string exclusionsetuptablename, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ExclusionSetupTableName.ToLower().Contains(exclusionsetuptablename.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.ExclusionSetupTableName.Contains(exclusionsetuptablename)).ToList<ICedant_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Cedant_Audit entities in the database by PostponementSetupTableName
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		public virtual IList<ICedant_Audit> SearchByPostponementSetupTableName(string postponementsetuptablename, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.PostponementSetupTableName.ToLower().Contains(postponementsetuptablename.ToLower())).ToList<ICedant_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Cedant_Audit>(o => o.PostponementSetupTableName.Contains(postponementsetuptablename)).ToList<ICedant_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Cedant_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedant_Audit entity)
		{
			var entityToSave = new Cedant_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Cedant_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedant_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Cedant_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Cedant_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
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
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Cedant_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedant_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Cedant_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Cedant_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Cedant_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Cedant_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Cedant_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
