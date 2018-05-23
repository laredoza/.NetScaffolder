﻿
// <copyright file="PluginOneLifeBatchRunPolicyDto.g.cs" company="MIT">
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
	public partial class PluginOneLifeBatchRunPolicyDto : IPluginOneLifeBatchRunPolicy 
	{
		#region CTOR
		
		public PluginOneLifeBatchRunPolicyDto()
		{
			this.PluginOneLifeBatchRunException = new List <IPluginOneLifeBatchRunException>();
			this.PluginOneLifeBatchRunUnAnsweredQuestion = new List <IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
		public PluginOneLifeBatchRunPolicyDto(IPluginOneLifeBatchRunPolicy item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PluginOneLifeBatchRunId = item.PluginOneLifeBatchRunId;
			this.PolicyId = item.PolicyId;
			this.Completed = item.Completed;
			this.HasError = item.HasError;
			this.Message = item.Message;
			this.XmlFile = item.XmlFile;
			this.Name = item.Name;
			this.Surname = item.Surname;
			this.ExternalReference = item.ExternalReference;
			this.PluginOneLifeBatchRunException = new List <IPluginOneLifeBatchRunException>();
			this.PluginOneLifeBatchRunUnAnsweredQuestion = new List <IPluginOneLifeBatchRunUnAnsweredQuestion>();

			if(deep)
			{
				if(item.PluginOneLifeBatchRunException != null)
				{
					foreach(var childItem in item.PluginOneLifeBatchRunException)
					{
						this.PluginOneLifeBatchRunException.Add(new PluginOneLifeBatchRunExceptionDto(childItem, deep));
					}
				}
				if(item.PluginOneLifeBatchRunUnAnsweredQuestion != null)
				{
					foreach(var childItem in item.PluginOneLifeBatchRunUnAnsweredQuestion)
					{
						this.PluginOneLifeBatchRunUnAnsweredQuestion.Add(new PluginOneLifeBatchRunUnAnsweredQuestionDto(childItem, deep));
					}
				}
                if(item.PluginOneLifeBatchRun != null)
                {
				    this.PluginOneLifeBatchRun = new PluginOneLifeBatchRunDto(item.PluginOneLifeBatchRun, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> PluginOneLifeBatchRunId { get; set; }
		public Nullable<int> PolicyId { get; set; }
		public Nullable<bool> Completed { get; set; }
		public Nullable<bool> HasError { get; set; }
		public string Message { get; set; }
		public byte[] XmlFile { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string ExternalReference { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IPluginOneLifeBatchRunException> PluginOneLifeBatchRunException { get; set; }
		public IList<IPluginOneLifeBatchRunUnAnsweredQuestion> PluginOneLifeBatchRunUnAnsweredQuestion { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IPluginOneLifeBatchRun PluginOneLifeBatchRun { get; set; }
		
		#endregion
	}
}