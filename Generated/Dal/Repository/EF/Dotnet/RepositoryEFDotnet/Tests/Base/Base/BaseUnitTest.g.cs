
// <copyright file="BaseUnitTest.g.cs.g.cs" company="MIT">
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

using Banking.Models.Dto;
using Banking.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest.Base
{
	public abstract partial class BaseUnitTest
	{
        protected virtual void Check_EntityCount(int expected, int actual, string name)
        {
            Assert.AreEqual(expected, actual, $"Incorrect number of {name} found.");
        }

		#region Fields


        protected virtual void Check_BankAccount(IBankAccount dto, IBankAccount savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.BankAccountId, savedEntity.BankAccountId, $"Customer.BankAccountId incorrect.");
            Assert.AreEqual(dto.BankAccountNumber, savedEntity.BankAccountNumber, $"Customer.BankAccountNumber incorrect.");
            Assert.AreEqual(dto.Balance, savedEntity.Balance, $"Customer.Balance incorrect.");
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"Customer.CustomerId incorrect.");
            Assert.AreEqual(dto.Locked, savedEntity.Locked, $"Customer.Locked incorrect.");
        }		

        protected virtual void Check_BankTransfers(IBankTransfers dto, IBankTransfers savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.BankTransferId, savedEntity.BankTransferId, $"Customer.BankTransferId incorrect.");
            Assert.AreEqual(dto.FromBankAccountId, savedEntity.FromBankAccountId, $"Customer.FromBankAccountId incorrect.");
            Assert.AreEqual(dto.ToBankAccountId, savedEntity.ToBankAccountId, $"Customer.ToBankAccountId incorrect.");
            Assert.AreEqual(dto.Amount, savedEntity.Amount, $"Customer.Amount incorrect.");
            Assert.AreEqual(dto.TransferDate, savedEntity.TransferDate, $"Customer.TransferDate incorrect.");
        }		

        protected virtual void Check_Book(IBook dto, IBook savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.ProductId, savedEntity.ProductId, $"Customer.ProductId incorrect.");
            Assert.AreEqual(dto.Publisher, savedEntity.Publisher, $"Customer.Publisher incorrect.");
        }		

        protected virtual void Check_Country(ICountry dto, ICountry savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.CountryId, savedEntity.CountryId, $"Customer.CountryId incorrect.");
            Assert.AreEqual(dto.CountryName, savedEntity.CountryName, $"Customer.CountryName incorrect.");
        }		

        protected virtual void Check_Customer(ICustomer dto, ICustomer savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"Customer.CustomerId incorrect.");
            Assert.AreEqual(dto.CustomerCode, savedEntity.CustomerCode, $"Customer.CustomerCode incorrect.");
            Assert.AreEqual(dto.CompanyName, savedEntity.CompanyName, $"Customer.CompanyName incorrect.");
            Assert.AreEqual(dto.ContactName, savedEntity.ContactName, $"Customer.ContactName incorrect.");
            Assert.AreEqual(dto.ContactTitle, savedEntity.ContactTitle, $"Customer.ContactTitle incorrect.");
            Assert.AreEqual(dto.Address, savedEntity.Address, $"Customer.Address incorrect.");
            Assert.AreEqual(dto.City, savedEntity.City, $"Customer.City incorrect.");
            Assert.AreEqual(dto.PostalCode, savedEntity.PostalCode, $"Customer.PostalCode incorrect.");
            Assert.AreEqual(dto.Telephone, savedEntity.Telephone, $"Customer.Telephone incorrect.");
            Assert.AreEqual(dto.Fax, savedEntity.Fax, $"Customer.Fax incorrect.");
            Assert.AreEqual(dto.CountryId, savedEntity.CountryId, $"Customer.CountryId incorrect.");
            Assert.AreEqual(dto.Photo, savedEntity.Photo, $"Customer.Photo incorrect.");
            Assert.AreEqual(dto.IsEnabled, savedEntity.IsEnabled, $"Customer.IsEnabled incorrect.");
        }		

        protected virtual void Check_Order(IOrder dto, IOrder savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.OrderId, savedEntity.OrderId, $"Customer.OrderId incorrect.");
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"Customer.CustomerId incorrect.");
            Assert.AreEqual(dto.OrderDate, savedEntity.OrderDate, $"Customer.OrderDate incorrect.");
            Assert.AreEqual(dto.DeliveryDate, savedEntity.DeliveryDate, $"Customer.DeliveryDate incorrect.");
            Assert.AreEqual(dto.ShippingName, savedEntity.ShippingName, $"Customer.ShippingName incorrect.");
            Assert.AreEqual(dto.ShippingAddress, savedEntity.ShippingAddress, $"Customer.ShippingAddress incorrect.");
            Assert.AreEqual(dto.ShippingCity, savedEntity.ShippingCity, $"Customer.ShippingCity incorrect.");
            Assert.AreEqual(dto.ShippingZip, savedEntity.ShippingZip, $"Customer.ShippingZip incorrect.");
        }		

        protected virtual void Check_OrderDetails(IOrderDetails dto, IOrderDetails savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.OrderDetailsId, savedEntity.OrderDetailsId, $"Customer.OrderDetailsId incorrect.");
            Assert.AreEqual(dto.OrderId, savedEntity.OrderId, $"Customer.OrderId incorrect.");
            Assert.AreEqual(dto.ProductId, savedEntity.ProductId, $"Customer.ProductId incorrect.");
            Assert.AreEqual(dto.UnitPrice, savedEntity.UnitPrice, $"Customer.UnitPrice incorrect.");
            Assert.AreEqual(dto.Amount, savedEntity.Amount, $"Customer.Amount incorrect.");
            Assert.AreEqual(dto.Discount, savedEntity.Discount, $"Customer.Discount incorrect.");
        }		

        protected virtual void Check_Product(IProduct dto, IProduct savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.ProductId, savedEntity.ProductId, $"Customer.ProductId incorrect.");
            Assert.AreEqual(dto.ProductDescription, savedEntity.ProductDescription, $"Customer.ProductDescription incorrect.");
            Assert.AreEqual(dto.UnitPrice, savedEntity.UnitPrice, $"Customer.UnitPrice incorrect.");
            Assert.AreEqual(dto.UnitAmount, savedEntity.UnitAmount, $"Customer.UnitAmount incorrect.");
            Assert.AreEqual(dto.Publisher, savedEntity.Publisher, $"Customer.Publisher incorrect.");
            Assert.AreEqual(dto.AmountInStock, savedEntity.AmountInStock, $"Customer.AmountInStock incorrect.");
        }		

        protected virtual void Check_Software(ISoftware dto, ISoftware savedEntity)
        { 
            Assert.IsNotNull(savedEntity);
			Assert.IsNotNull(dto);
			
			// Test Fields
            Assert.AreEqual(dto.ProductId, savedEntity.ProductId, $"Customer.ProductId incorrect.");
            Assert.AreEqual(dto.LicenseCode, savedEntity.LicenseCode, $"Customer.LicenseCode incorrect.");
        }		

		#endregion
		
	}
}
