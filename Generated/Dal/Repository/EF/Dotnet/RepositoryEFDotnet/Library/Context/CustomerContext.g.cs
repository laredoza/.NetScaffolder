
// <copyright file="CustomerContext.g.cs" company="MIT">
//  Copyright (c) 2018 All Rights Reserved
// </copyright>  

// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.Data.Entity;

namespace Banking.Models.Context.Customers
{
	public partial class Customercontext 
	{
		#region Db Sets
		
				public virtual DbSet<Country> Country;
				public virtual DbSet<Customer> Customer;
				public virtual DbSet<Order> Order;
				public virtual DbSet<Orderdetails> Orderdetails;
				public virtual DbSet<Product> Product;
				public virtual DbSet<Software> Software;
		
		#endregion // EntitySets
	}
}
