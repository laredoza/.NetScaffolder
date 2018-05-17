
// <copyright file="Policy.g.cs" company="MIT">
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
	public partial class Policy : IPolicy 
	{
		#region CTOR
		
		public Policy()
		{
			this.OutcomeResult = new List <OutcomeResult>();
			this.PolicyReference = new List <PolicyReference>();
			this.PolicyStatusCounter = new List <PolicyStatusCounter>();
			this.Product = new List <Product>();
			this.Questionnaire = new List <Questionnaire>();
		}
		
		public Policy(IPolicy item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PolicyNumber = item.PolicyNumber;
			this.Premium = item.Premium;
			this.SumAssured = item.SumAssured;
			this.ActivationDate = item.ActivationDate;
			this.QuestionnaireId = item.QuestionnaireId;
			this.Status = item.Status;
			this.ExternalReferenceId = item.ExternalReferenceId;
			this.ExternalReferenceLocked = item.ExternalReferenceLocked;
			this.AcceptedStatus = item.AcceptedStatus;
			this.AcceptedDate = item.AcceptedDate;
			this.CustomerId = item.CustomerId;
			this.OutcomeResult = new List <OutcomeResult>();
			this.PolicyReference = new List <PolicyReference>();
			this.PolicyStatusCounter = new List <PolicyStatusCounter>();
			this.Product = new List <Product>();
			this.Questionnaire = new List <Questionnaire>();

			if(deep)
			{
				if(item.OutcomeResult != null)
				{
					foreach(var childItem in item.OutcomeResult)
					{
						this.OutcomeResult.Add(new OutcomeResult(childItem, deep));
					}
				}
				if(item.PolicyReference != null)
				{
					foreach(var childItem in item.PolicyReference)
					{
						this.PolicyReference.Add(new PolicyReference(childItem, deep));
					}
				}
				if(item.PolicyStatusCounter != null)
				{
					foreach(var childItem in item.PolicyStatusCounter)
					{
						this.PolicyStatusCounter.Add(new PolicyStatusCounter(childItem, deep));
					}
				}
				if(item.Product != null)
				{
					foreach(var childItem in item.Product)
					{
						this.Product.Add(new Product(childItem, deep));
					}
				}
				if(item.Questionnaire != null)
				{
					foreach(var childItem in item.Questionnaire)
					{
						this.Questionnaire.Add(new Questionnaire(childItem, deep));
					}
				}
				if(item.Customer != null)
                {
                    this.Customer = new Customer(item.Customer, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> PolicyNumber { get; set; }
		public Nullable<decimal> Premium { get; set; }
		public Nullable<decimal> SumAssured { get; set; }
		public Nullable<DateTime> ActivationDate { get; set; }
		public Nullable<int> QuestionnaireId { get; set; }
		public Nullable<int> Status { get; set; }
		public string ExternalReferenceId { get; set; }
		public Nullable<bool> ExternalReferenceLocked { get; set; }
		public Nullable<int> AcceptedStatus { get; set; }
		public Nullable<DateTime> AcceptedDate { get; set; }
		public Nullable<int> CustomerId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<OutcomeResult> OutcomeResult { get; set; }

        IList<IOutcomeResult> IPolicy.OutcomeResult 
		{ 
			get
			{
				return (IList<IOutcomeResult>)this.OutcomeResult;
			}
			set
			{
				this.OutcomeResult = (IList<OutcomeResult>)value;
			}			
		}
        
        public virtual IList<PolicyReference> PolicyReference { get; set; }

        IList<IPolicyReference> IPolicy.PolicyReference 
		{ 
			get
			{
				return (IList<IPolicyReference>)this.PolicyReference;
			}
			set
			{
				this.PolicyReference = (IList<PolicyReference>)value;
			}			
		}
        
        public virtual IList<PolicyStatusCounter> PolicyStatusCounter { get; set; }

        IList<IPolicyStatusCounter> IPolicy.PolicyStatusCounter 
		{ 
			get
			{
				return (IList<IPolicyStatusCounter>)this.PolicyStatusCounter;
			}
			set
			{
				this.PolicyStatusCounter = (IList<PolicyStatusCounter>)value;
			}			
		}
        
        public virtual IList<Product> Product { get; set; }

        IList<IProduct> IPolicy.Product 
		{ 
			get
			{
				return (IList<IProduct>)this.Product;
			}
			set
			{
				this.Product = (IList<Product>)value;
			}			
		}
        
        public virtual IList<Questionnaire> Questionnaire { get; set; }

        IList<IQuestionnaire> IPolicy.Questionnaire 
		{ 
			get
			{
				return (IList<IQuestionnaire>)this.Questionnaire;
			}
			set
			{
				this.Questionnaire = (IList<Questionnaire>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Customer Customer { get; set; }

		ICustomer IPolicy.Customer 
		{ 
			get
			{
				return this.Customer;
			}
			set
			{
				this.Customer = (Customer)value;
			}
		}
		
		#endregion
	}
}
