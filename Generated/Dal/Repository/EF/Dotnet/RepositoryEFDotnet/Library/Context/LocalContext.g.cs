
// <copyright file="LocalContext.g.cs" company="MIT">
//  Copyright (c) 2018 All Rights Reserved
// </copyright>  

// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.Data.Entity;

namespace Banking.Models.Context.Context
{
	public partial class Localcontext 
	{
		#region Db Sets
		
				public virtual DbSet<Bankaccount> Bankaccount;
				public virtual DbSet<Banktransfers> Banktransfers;
		
		#endregion // EntitySets
	}
}
