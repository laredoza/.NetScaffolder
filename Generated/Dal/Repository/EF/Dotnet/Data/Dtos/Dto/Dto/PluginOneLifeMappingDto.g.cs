
// <copyright file="PluginOneLifeMappingDto.g.cs" company="MIT">
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
	public partial class PluginOneLifeMappingDto : IPluginOneLifeMapping 
	{
		#region CTOR
		
		public PluginOneLifeMappingDto()
		{
		}
		
		public PluginOneLifeMappingDto(IPluginOneLifeMapping item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PluginOneLifeCedantId = item.PluginOneLifeCedantId;
			this.MappingID = item.MappingID;
			this.Category = item.Category;
			this.Section = item.Section;
			this.Text = item.Text;
			this.Min = item.Min;
			this.Max = item.Max;
			this.SectionProfileId = item.SectionProfileId;
			this.SectionProfile = item.SectionProfile;
			this.QuestionProfileId = item.QuestionProfileId;
			this.QuestionProfile = item.QuestionProfile;
			this.AnswerProfileId = item.AnswerProfileId;
			this.AnswerProfile = item.AnswerProfile;
			this.ExternalRef = item.ExternalRef;
			this.Value = item.Value;

			if(deep)
			{
                if(item.PluginOneLifeCedant != null)
                {
				    this.PluginOneLifeCedant = new PluginOneLifeCedantDto(item.PluginOneLifeCedant, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> PluginOneLifeCedantId { get; set; }
		public string MappingID { get; set; }
		public string Category { get; set; }
		public string Section { get; set; }
		public string Text { get; set; }
		public string Min { get; set; }
		public string Max { get; set; }
		public Nullable<int> SectionProfileId { get; set; }
		public string SectionProfile { get; set; }
		public Nullable<int> QuestionProfileId { get; set; }
		public string QuestionProfile { get; set; }
		public Nullable<int> AnswerProfileId { get; set; }
		public string AnswerProfile { get; set; }
		public string ExternalRef { get; set; }
		public string Value { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IPluginOneLifeCedant PluginOneLifeCedant { get; set; }
		
		#endregion
	}
}
