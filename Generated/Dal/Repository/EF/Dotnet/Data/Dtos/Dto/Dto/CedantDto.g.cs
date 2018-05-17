
// <copyright file="CedantDto.g.cs" company="MIT">
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
using Banking.Models.Interfaces;

namespace Banking.Models.Dto
{
	public partial class CedantDto : ICedant 
	{
		#region CTOR
		
		public CedantDto()
		{
			this.AccessRestriction = new List <IAccessRestriction>();
			this.CedantApplicantAttribute = new List <ICedantApplicantAttribute>();
			this.CedantDomain = new List <ICedantDomain>();
			this.CedantMandatoryField = new List <ICedantMandatoryField>();
			this.CedantOutcomeGroup = new List <ICedantOutcomeGroup>();
			this.CedantProduct = new List <ICedantProduct>();
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.CustmerApplicantAttribute = new List <ICustmerApplicantAttribute>();
			this.Customer = new List <ICustomer>();
			this.PluginOneLifeCedant = new List <IPluginOneLifeCedant>();
			this.QUIRCUser = new List <IQUIRCUser>();
			this.QUIRCUserCedant = new List <IQUIRCUserCedant>();
		}
		
		public CedantDto(ICedant item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.TimeLimit = item.TimeLimit;
			this.isChangeLimited = item.isChangeLimited;
			this.RemainingChanges = item.RemainingChanges;
			this.LimitInternetUserOnly = item.LimitInternetUserOnly;
			this.BannerImage = item.BannerImage;
			this.BannerImageType = item.BannerImageType;
			this.TermsConditions = item.TermsConditions;
			this.ReportName = item.ReportName;
			this.License = item.License;
			this.Validator = item.Validator;
			this.LicenseKey = item.LicenseKey;
			this.LicenseSalt = item.LicenseSalt;
			this.CedantUniqueIdentifier = item.CedantUniqueIdentifier;
			this.ExclusionSetupTableName = item.ExclusionSetupTableName;
			this.PostponementSetupTableName = item.PostponementSetupTableName;
			this.QuestionnaireProfileVersionId = item.QuestionnaireProfileVersionId;
			this.LoadingUrl = item.LoadingUrl;
			this.AccessRestriction = new List <IAccessRestriction>();
			this.CedantApplicantAttribute = new List <ICedantApplicantAttribute>();
			this.CedantDomain = new List <ICedantDomain>();
			this.CedantMandatoryField = new List <ICedantMandatoryField>();
			this.CedantOutcomeGroup = new List <ICedantOutcomeGroup>();
			this.CedantProduct = new List <ICedantProduct>();
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.CustmerApplicantAttribute = new List <ICustmerApplicantAttribute>();
			this.Customer = new List <ICustomer>();
			this.PluginOneLifeCedant = new List <IPluginOneLifeCedant>();
			this.QUIRCUser = new List <IQUIRCUser>();
			this.QUIRCUserCedant = new List <IQUIRCUserCedant>();

			if(deep)
			{
				if(item.AccessRestriction != null)
				{
					foreach(var childItem in item.AccessRestriction)
					{
						this.AccessRestriction.Add(new AccessRestrictionDto(childItem, deep));
					}
				}
				if(item.CedantApplicantAttribute != null)
				{
					foreach(var childItem in item.CedantApplicantAttribute)
					{
						this.CedantApplicantAttribute.Add(new CedantApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.CedantDomain != null)
				{
					foreach(var childItem in item.CedantDomain)
					{
						this.CedantDomain.Add(new CedantDomainDto(childItem, deep));
					}
				}
				if(item.CedantMandatoryField != null)
				{
					foreach(var childItem in item.CedantMandatoryField)
					{
						this.CedantMandatoryField.Add(new CedantMandatoryFieldDto(childItem, deep));
					}
				}
				if(item.CedantOutcomeGroup != null)
				{
					foreach(var childItem in item.CedantOutcomeGroup)
					{
						this.CedantOutcomeGroup.Add(new CedantOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.CedantProduct != null)
				{
					foreach(var childItem in item.CedantProduct)
					{
						this.CedantProduct.Add(new CedantProductDto(childItem, deep));
					}
				}
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimitDto(childItem, deep));
					}
				}
				if(item.CustmerApplicantAttribute != null)
				{
					foreach(var childItem in item.CustmerApplicantAttribute)
					{
						this.CustmerApplicantAttribute.Add(new CustmerApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.Customer != null)
				{
					foreach(var childItem in item.Customer)
					{
						this.Customer.Add(new CustomerDto(childItem, deep));
					}
				}
				if(item.PluginOneLifeCedant != null)
				{
					foreach(var childItem in item.PluginOneLifeCedant)
					{
						this.PluginOneLifeCedant.Add(new PluginOneLifeCedantDto(childItem, deep));
					}
				}
				if(item.QUIRCUser != null)
				{
					foreach(var childItem in item.QUIRCUser)
					{
						this.QUIRCUser.Add(new QUIRCUserDto(childItem, deep));
					}
				}
				if(item.QUIRCUserCedant != null)
				{
					foreach(var childItem in item.QUIRCUserCedant)
					{
						this.QUIRCUserCedant.Add(new QUIRCUserCedantDto(childItem, deep));
					}
				}
                if(item.QuestionnaireProfileVersion != null)
                {
				    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersionDto(item.QuestionnaireProfileVersion, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public Nullable<long> TimeLimit { get; set; }
		public Nullable<bool> isChangeLimited { get; set; }
		public Nullable<int> RemainingChanges { get; set; }
		public Nullable<bool> LimitInternetUserOnly { get; set; }
		public byte[] BannerImage { get; set; }
		public string BannerImageType { get; set; }
		public string TermsConditions { get; set; }
		public string ReportName { get; set; }
		public string License { get; set; }
		public string Validator { get; set; }
		public string LicenseKey { get; set; }
		public string LicenseSalt { get; set; }
		public Nullable<Guid> CedantUniqueIdentifier { get; set; }
		public string ExclusionSetupTableName { get; set; }
		public string PostponementSetupTableName { get; set; }
		public Nullable<int> QuestionnaireProfileVersionId { get; set; }
		public string LoadingUrl { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAccessRestriction> AccessRestriction { get; set; }
		public IList<ICedantApplicantAttribute> CedantApplicantAttribute { get; set; }
		public IList<ICedantDomain> CedantDomain { get; set; }
		public IList<ICedantMandatoryField> CedantMandatoryField { get; set; }
		public IList<ICedantOutcomeGroup> CedantOutcomeGroup { get; set; }
		public IList<ICedantProduct> CedantProduct { get; set; }
		public IList<ICedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }
		public IList<ICustmerApplicantAttribute> CustmerApplicantAttribute { get; set; }
		public IList<ICustomer> Customer { get; set; }
		public IList<IPluginOneLifeCedant> PluginOneLifeCedant { get; set; }
		public IList<IQUIRCUser> QUIRCUser { get; set; }
		public IList<IQUIRCUserCedant> QUIRCUserCedant { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IQuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }
		
		#endregion
	}
}
