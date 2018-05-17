
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
using Banking.Models.Interfaces;

namespace Banking.Models.Entity
{
	public partial class Cedant : ICedant 
	{
		#region CTOR
		
		public Cedant()
		{
			this.AccessRestriction = new List <AccessRestriction>();
			this.CedantApplicantAttribute = new List <CedantApplicantAttribute>();
			this.CedantDomain = new List <CedantDomain>();
			this.CedantMandatoryField = new List <CedantMandatoryField>();
			this.CedantOutcomeGroup = new List <CedantOutcomeGroup>();
			this.CedantProduct = new List <CedantProduct>();
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.CustmerApplicantAttribute = new List <CustmerApplicantAttribute>();
			this.Customer = new List <Customer>();
			this.PluginOneLifeCedant = new List <PluginOneLifeCedant>();
			this.QUIRCUser = new List <QUIRCUser>();
			this.QUIRCUserCedant = new List <QUIRCUserCedant>();
		}
		
		public Cedant(ICedant item, bool deep = false)
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
			this.AccessRestriction = new List <AccessRestriction>();
			this.CedantApplicantAttribute = new List <CedantApplicantAttribute>();
			this.CedantDomain = new List <CedantDomain>();
			this.CedantMandatoryField = new List <CedantMandatoryField>();
			this.CedantOutcomeGroup = new List <CedantOutcomeGroup>();
			this.CedantProduct = new List <CedantProduct>();
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.CustmerApplicantAttribute = new List <CustmerApplicantAttribute>();
			this.Customer = new List <Customer>();
			this.PluginOneLifeCedant = new List <PluginOneLifeCedant>();
			this.QUIRCUser = new List <QUIRCUser>();
			this.QUIRCUserCedant = new List <QUIRCUserCedant>();

			if(deep)
			{
				if(item.AccessRestriction != null)
				{
					foreach(var childItem in item.AccessRestriction)
					{
						this.AccessRestriction.Add(new AccessRestriction(childItem, deep));
					}
				}
				if(item.CedantApplicantAttribute != null)
				{
					foreach(var childItem in item.CedantApplicantAttribute)
					{
						this.CedantApplicantAttribute.Add(new CedantApplicantAttribute(childItem, deep));
					}
				}
				if(item.CedantDomain != null)
				{
					foreach(var childItem in item.CedantDomain)
					{
						this.CedantDomain.Add(new CedantDomain(childItem, deep));
					}
				}
				if(item.CedantMandatoryField != null)
				{
					foreach(var childItem in item.CedantMandatoryField)
					{
						this.CedantMandatoryField.Add(new CedantMandatoryField(childItem, deep));
					}
				}
				if(item.CedantOutcomeGroup != null)
				{
					foreach(var childItem in item.CedantOutcomeGroup)
					{
						this.CedantOutcomeGroup.Add(new CedantOutcomeGroup(childItem, deep));
					}
				}
				if(item.CedantProduct != null)
				{
					foreach(var childItem in item.CedantProduct)
					{
						this.CedantProduct.Add(new CedantProduct(childItem, deep));
					}
				}
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimit(childItem, deep));
					}
				}
				if(item.CustmerApplicantAttribute != null)
				{
					foreach(var childItem in item.CustmerApplicantAttribute)
					{
						this.CustmerApplicantAttribute.Add(new CustmerApplicantAttribute(childItem, deep));
					}
				}
				if(item.Customer != null)
				{
					foreach(var childItem in item.Customer)
					{
						this.Customer.Add(new Customer(childItem, deep));
					}
				}
				if(item.PluginOneLifeCedant != null)
				{
					foreach(var childItem in item.PluginOneLifeCedant)
					{
						this.PluginOneLifeCedant.Add(new PluginOneLifeCedant(childItem, deep));
					}
				}
				if(item.QUIRCUser != null)
				{
					foreach(var childItem in item.QUIRCUser)
					{
						this.QUIRCUser.Add(new QUIRCUser(childItem, deep));
					}
				}
				if(item.QUIRCUserCedant != null)
				{
					foreach(var childItem in item.QUIRCUserCedant)
					{
						this.QUIRCUserCedant.Add(new QUIRCUserCedant(childItem, deep));
					}
				}
				if(item.QuestionnaireProfileVersion != null)
                {
                    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersion(item.QuestionnaireProfileVersion, deep);
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
        
        public virtual IList<AccessRestriction> AccessRestriction { get; set; }

        IList<IAccessRestriction> ICedant.AccessRestriction 
		{ 
			get
			{
				return (IList<IAccessRestriction>)this.AccessRestriction;
			}
			set
			{
				this.AccessRestriction = (IList<AccessRestriction>)value;
			}			
		}
        
        public virtual IList<CedantApplicantAttribute> CedantApplicantAttribute { get; set; }

        IList<ICedantApplicantAttribute> ICedant.CedantApplicantAttribute 
		{ 
			get
			{
				return (IList<ICedantApplicantAttribute>)this.CedantApplicantAttribute;
			}
			set
			{
				this.CedantApplicantAttribute = (IList<CedantApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<CedantDomain> CedantDomain { get; set; }

        IList<ICedantDomain> ICedant.CedantDomain 
		{ 
			get
			{
				return (IList<ICedantDomain>)this.CedantDomain;
			}
			set
			{
				this.CedantDomain = (IList<CedantDomain>)value;
			}			
		}
        
        public virtual IList<CedantMandatoryField> CedantMandatoryField { get; set; }

        IList<ICedantMandatoryField> ICedant.CedantMandatoryField 
		{ 
			get
			{
				return (IList<ICedantMandatoryField>)this.CedantMandatoryField;
			}
			set
			{
				this.CedantMandatoryField = (IList<CedantMandatoryField>)value;
			}			
		}
        
        public virtual IList<CedantOutcomeGroup> CedantOutcomeGroup { get; set; }

        IList<ICedantOutcomeGroup> ICedant.CedantOutcomeGroup 
		{ 
			get
			{
				return (IList<ICedantOutcomeGroup>)this.CedantOutcomeGroup;
			}
			set
			{
				this.CedantOutcomeGroup = (IList<CedantOutcomeGroup>)value;
			}			
		}
        
        public virtual IList<CedantProduct> CedantProduct { get; set; }

        IList<ICedantProduct> ICedant.CedantProduct 
		{ 
			get
			{
				return (IList<ICedantProduct>)this.CedantProduct;
			}
			set
			{
				this.CedantProduct = (IList<CedantProduct>)value;
			}			
		}
        
        public virtual IList<CedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }

        IList<ICedantUserLoadingLimit> ICedant.CedantUserLoadingLimit 
		{ 
			get
			{
				return (IList<ICedantUserLoadingLimit>)this.CedantUserLoadingLimit;
			}
			set
			{
				this.CedantUserLoadingLimit = (IList<CedantUserLoadingLimit>)value;
			}			
		}
        
        public virtual IList<CustmerApplicantAttribute> CustmerApplicantAttribute { get; set; }

        IList<ICustmerApplicantAttribute> ICedant.CustmerApplicantAttribute 
		{ 
			get
			{
				return (IList<ICustmerApplicantAttribute>)this.CustmerApplicantAttribute;
			}
			set
			{
				this.CustmerApplicantAttribute = (IList<CustmerApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<Customer> Customer { get; set; }

        IList<ICustomer> ICedant.Customer 
		{ 
			get
			{
				return (IList<ICustomer>)this.Customer;
			}
			set
			{
				this.Customer = (IList<Customer>)value;
			}			
		}
        
        public virtual IList<PluginOneLifeCedant> PluginOneLifeCedant { get; set; }

        IList<IPluginOneLifeCedant> ICedant.PluginOneLifeCedant 
		{ 
			get
			{
				return (IList<IPluginOneLifeCedant>)this.PluginOneLifeCedant;
			}
			set
			{
				this.PluginOneLifeCedant = (IList<PluginOneLifeCedant>)value;
			}			
		}
        
        public virtual IList<QUIRCUser> QUIRCUser { get; set; }

        IList<IQUIRCUser> ICedant.QUIRCUser 
		{ 
			get
			{
				return (IList<IQUIRCUser>)this.QUIRCUser;
			}
			set
			{
				this.QUIRCUser = (IList<QUIRCUser>)value;
			}			
		}
        
        public virtual IList<QUIRCUserCedant> QUIRCUserCedant { get; set; }

        IList<IQUIRCUserCedant> ICedant.QUIRCUserCedant 
		{ 
			get
			{
				return (IList<IQUIRCUserCedant>)this.QUIRCUserCedant;
			}
			set
			{
				this.QUIRCUserCedant = (IList<QUIRCUserCedant>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual QuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }

		IQuestionnaireProfileVersion ICedant.QuestionnaireProfileVersion 
		{ 
			get
			{
				return this.QuestionnaireProfileVersion;
			}
			set
			{
				this.QuestionnaireProfileVersion = (QuestionnaireProfileVersion)value;
			}
		}
		
		#endregion
	}
}
