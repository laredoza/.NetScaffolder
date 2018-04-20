
// <copyright file="AccountContext.g.cs" company="MIT">
//  Copyright (c) 2018 All Rights Reserved
// </copyright>  

// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.Data.Entity;

namespace Banking.Models.Context.Accounts
{
	public partial class Accountcontext : BaseContext
	{
		#region Db Sets
		
				public virtual DbSet<Bankaccount> Bankaccount;
				public virtual DbSet<Banktransfers> Banktransfers;
		
		#endregion // EntitySets
	}
}
