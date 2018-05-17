
// <copyright file="PluginOneLifePolicyDto.g.cs" company="MIT">
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
	public partial class PluginOneLifePolicyDto : IPluginOneLifePolicy 
	{
		#region CTOR
		
		public PluginOneLifePolicyDto()
		{
			this.PluginOneLifeException = new List <IPluginOneLifeException>();
			this.PluginOneLifeUnAnsweredQuestion = new List <IPluginOneLifeUnAnsweredQuestion>();
		}
		
		public PluginOneLifePolicyDto(IPluginOneLifePolicy item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PluginOneLifeCedantId = item.PluginOneLifeCedantId;
			this.PolicyId = item.PolicyId;
			this.Name = item.Name;
			this.Surname = item.Surname;
			this.ExternalReference = item.ExternalReference;
			this.PluginOneLifeException = new List <IPluginOneLifeException>();
			this.PluginOneLifeUnAnsweredQuestion = new List <IPluginOneLifeUnAnsweredQuestion>();

			if(deep)
			{
				if(item.PluginOneLifeException != null)
				{
					foreach(var childItem in item.PluginOneLifeException)
					{
						this.PluginOneLifeException.Add(new PluginOneLifeExceptionDto(childItem, deep));
					}
				}
				if(item.PluginOneLifeUnAnsweredQuestion != null)
				{
					foreach(var childItem in item.PluginOneLifeUnAnsweredQuestion)
					{
						this.PluginOneLifeUnAnsweredQuestion.Add(new PluginOneLifeUnAnsweredQuestionDto(childItem, deep));
					}
				}
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
		public int PluginOneLifeCedantId { get; set; }
		public int PolicyId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string ExternalReference { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IPluginOneLifeException> PluginOneLifeException { get; set; }
		public IList<IPluginOneLifeUnAnsweredQuestion> PluginOneLifeUnAnsweredQuestion { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IPluginOneLifeCedant PluginOneLifeCedant { get; set; }
		
		#endregion
	}
}
