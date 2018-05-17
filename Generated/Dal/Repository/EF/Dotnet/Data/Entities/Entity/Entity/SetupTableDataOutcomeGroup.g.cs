
// <copyright file="SetupTableDataOutcomeGroup.g.cs" company="MIT">
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
	public partial class SetupTableDataOutcomeGroup : ISetupTableDataOutcomeGroup 
	{
		#region CTOR
		
		public SetupTableDataOutcomeGroup()
		{
		}
		
		public SetupTableDataOutcomeGroup(ISetupTableDataOutcomeGroup item, bool deep = false)
		{
			if(item == null) return;
			
			this.OutcomeGroupId = item.OutcomeGroupId;
			this.SetupTableDataId = item.SetupTableDataId;
			this.Id = item.Id;

			if(deep)
			{
				if(item.SetupTableData != null)
                {
                    this.SetupTableData = new SetupTableData(item.SetupTableData, deep);
                }
				if(item.OutcomeGroup != null)
                {
                    this.OutcomeGroup = new OutcomeGroup(item.OutcomeGroup, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int OutcomeGroupId { get; set; }
		public int SetupTableDataId { get; set; }
		public int Id { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual SetupTableData SetupTableData { get; set; }

		ISetupTableData ISetupTableDataOutcomeGroup.SetupTableData 
		{ 
			get
			{
				return this.SetupTableData;
			}
			set
			{
				this.SetupTableData = (SetupTableData)value;
			}
		}

        public virtual OutcomeGroup OutcomeGroup { get; set; }

		IOutcomeGroup ISetupTableDataOutcomeGroup.OutcomeGroup 
		{ 
			get
			{
				return this.OutcomeGroup;
			}
			set
			{
				this.OutcomeGroup = (OutcomeGroup)value;
			}
		}
		
		#endregion
	}
}
