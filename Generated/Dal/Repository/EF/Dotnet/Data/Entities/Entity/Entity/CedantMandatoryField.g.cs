
// <copyright file="CedantMandatoryField.g.cs" company="MIT">
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
	public partial class CedantMandatoryField : ICedantMandatoryField 
	{
		#region CTOR
		
		public CedantMandatoryField()
		{
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();
		}
		
		public CedantMandatoryField(ICedantMandatoryField item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.MandatoryFieldName = item.MandatoryFieldName;
			this.Selected = item.Selected;
			this.ValidateType = item.ValidateType;
			this.CedantId = item.CedantId;
			this.MandatoryFieldId = item.MandatoryFieldId;
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();

			if(deep)
			{
				if(item.CedantMandatoryFieldConfig != null)
				{
					foreach(var childItem in item.CedantMandatoryFieldConfig)
					{
						this.CedantMandatoryFieldConfig.Add(new CedantMandatoryFieldConfig(childItem, deep));
					}
				}
				if(item.Cedant != null)
                {
                    this.Cedant = new Cedant(item.Cedant, deep);
                }
				if(item.MandatoryField != null)
                {
                    this.MandatoryField = new MandatoryField(item.MandatoryField, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string MandatoryFieldName { get; set; }
		public Nullable<bool> Selected { get; set; }
		public Nullable<int> ValidateType { get; set; }
		public Nullable<int> CedantId { get; set; }
		public Nullable<int> MandatoryFieldId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<CedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }

        IList<ICedantMandatoryFieldConfig> ICedantMandatoryField.CedantMandatoryFieldConfig 
		{ 
			get
			{
				return (IList<ICedantMandatoryFieldConfig>)this.CedantMandatoryFieldConfig;
			}
			set
			{
				this.CedantMandatoryFieldConfig = (IList<CedantMandatoryFieldConfig>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Cedant Cedant { get; set; }

		ICedant ICedantMandatoryField.Cedant 
		{ 
			get
			{
				return this.Cedant;
			}
			set
			{
				this.Cedant = (Cedant)value;
			}
		}

        public virtual MandatoryField MandatoryField { get; set; }

		IMandatoryField ICedantMandatoryField.MandatoryField 
		{ 
			get
			{
				return this.MandatoryField;
			}
			set
			{
				this.MandatoryField = (MandatoryField)value;
			}
		}
		
		#endregion
	}
}
