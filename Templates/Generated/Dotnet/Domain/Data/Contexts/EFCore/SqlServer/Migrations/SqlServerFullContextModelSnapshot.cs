﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryEFDotnet.Data.Context.EFCore;

namespace RepositoryEFDotnet.Contexts.EFCore.SqlServer.Migrations
{
    [DbContext(typeof(SqlServerFullContext))]
    partial class SqlServerFullContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .HasColumnName("BankAccountId");

                    b.Property<decimal>("Balance")
                        .HasColumnName("Balance")
                        .HasColumnType("decimal(19, 4)");

                    b.Property<string>("BankAccountNumber")
                        .IsRequired()
                        .HasColumnName("BankAccountNumber")
                        .HasMaxLength(10);

                    b.Property<int?>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<bool>("Locked")
                        .HasColumnName("Locked");

                    b.HasKey("BankAccountId");

                    b.HasIndex("BankAccountId")
                        .IsUnique()
                        .HasName("UQ__BankAcco__4FC8E4A0C45281C8");

                    b.HasIndex("CustomerId")
                        .HasName("IX_CustomerId");

                    b.ToTable("BankAccount","dbo");

                    b.HasData(
                        new
                        {
                            BankAccountId = 1,
                            Balance = 10000m,
                            BankAccountNumber = "001",
                            CustomerId = 1,
                            Locked = false
                        },
                        new
                        {
                            BankAccountId = 2,
                            Balance = 20000m,
                            BankAccountNumber = "002",
                            CustomerId = 2,
                            Locked = false
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.BankTransfers", b =>
                {
                    b.Property<int>("BankTransferId")
                        .HasColumnName("BankTransferId");

                    b.Property<decimal>("Amount")
                        .HasColumnName("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("FromBankAccountId")
                        .HasColumnName("FromBankAccountId");

                    b.Property<int>("ToBankAccountId")
                        .HasColumnName("ToBankAccountId");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnName("TransferDate");

                    b.HasKey("BankTransferId");

                    b.HasIndex("BankTransferId")
                        .IsUnique()
                        .HasName("UQ__BankTran__2E82727AB11DB584");

                    b.HasIndex("ToBankAccountId")
                        .HasName("IX_ToBankAccountId");

                    b.ToTable("BankTransfers","dbo");

                    b.HasData(
                        new
                        {
                            BankTransferId = 1,
                            Amount = 100m,
                            FromBankAccountId = 1,
                            ToBankAccountId = 2,
                            TransferDate = new DateTime(2018, 12, 28, 17, 52, 24, 486, DateTimeKind.Local).AddTicks(2898)
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Book", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnName("Publisher")
                        .HasMaxLength(200);

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId")
                        .HasName("IX_ProductId");

                    b.ToTable("Book","dbo");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Publisher = "Best Book Publisher Ever"
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .HasColumnName("CountryId");

                    b.Property<string>("CountryName")
                        .HasColumnName("CountryName")
                        .HasMaxLength(100);

                    b.HasKey("CountryId");

                    b.HasIndex("CountryId")
                        .IsUnique()
                        .HasName("UQ__Country__10D1609E8CC26505");

                    b.ToTable("Country","dbo");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "US"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "UK"
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnName("CompanyName")
                        .HasMaxLength(50);

                    b.Property<string>("ContactName")
                        .HasColumnName("ContactName")
                        .HasMaxLength(50);

                    b.Property<string>("ContactTitle")
                        .HasColumnName("ContactTitle")
                        .HasMaxLength(50);

                    b.Property<int?>("CountryId")
                        .HasColumnName("CountryId");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnName("CustomerCode")
                        .HasMaxLength(5);

                    b.Property<string>("Fax")
                        .HasColumnName("Fax")
                        .HasMaxLength(50);

                    b.Property<bool>("IsEnabled")
                        .HasColumnName("IsEnabled");

                    b.Property<string>("Photo")
                        .HasColumnName("Photo")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasColumnName("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Telephone")
                        .HasColumnName("Telephone")
                        .HasMaxLength(50);

                    b.HasKey("CustomerId");

                    b.HasIndex("CountryId")
                        .HasName("IX_CountryId");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasName("UQ__Customer__A4AE64D98B60CE6B");

                    b.ToTable("Customer","dbo");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "1st Road",
                            City = "New York",
                            CompanyName = "New York Books",
                            ContactName = "Bob",
                            ContactTitle = "Mr",
                            CountryId = 1,
                            CustomerCode = "001",
                            Fax = "123456789",
                            IsEnabled = true,
                            Photo = "",
                            PostalCode = "001",
                            Telephone = "123456789"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "2nd Road",
                            City = "London",
                            CompanyName = "London Software",
                            ContactName = "Mary",
                            ContactTitle = "Miss",
                            CountryId = 2,
                            CustomerCode = "002",
                            Fax = "0123456789",
                            IsEnabled = true,
                            Photo = "",
                            PostalCode = "002",
                            Telephone = "0123456789"
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderId");

                    b.Property<int?>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnName("DeliveryDate");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnName("OrderDate");

                    b.Property<string>("ShippingAddress")
                        .HasColumnName("ShippingAddress")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingCity")
                        .HasColumnName("ShippingCity")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingName")
                        .HasColumnName("ShippingName")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingZip")
                        .HasColumnName("ShippingZip")
                        .HasMaxLength(50);

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId")
                        .HasName("IX_CustomerId");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasName("UQ__Order__C3905BCE3C614174");

                    b.ToTable("Order","dbo");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 2,
                            DeliveryDate = new DateTime(2018, 12, 28, 17, 52, 24, 488, DateTimeKind.Local).AddTicks(7501),
                            OrderDate = new DateTime(2018, 12, 28, 17, 52, 24, 488, DateTimeKind.Local).AddTicks(6535),
                            ShippingAddress = "2nd road",
                            ShippingCity = "London",
                            ShippingName = "Mary",
                            ShippingZip = "123"
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .HasColumnName("OrderDetailsId");

                    b.Property<short?>("Amount")
                        .HasColumnName("Amount");

                    b.Property<float?>("Discount")
                        .HasColumnName("Discount");

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderId");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnName("UnitPrice")
                        .HasColumnType("decimal(19, 4)");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("OrderDetailsId")
                        .IsUnique()
                        .HasName("UQ__OrderDet__9DD74DBC8AA17DA0");

                    b.HasIndex("OrderId")
                        .HasName("IX_OrderId");

                    b.HasIndex("ProductId")
                        .HasName("IX_ProductId");

                    b.ToTable("OrderDetails","dbo");

                    b.HasData(
                        new
                        {
                            OrderDetailsId = 1,
                            Amount = (short)100,
                            Discount = 0f,
                            OrderId = 1,
                            ProductId = 1,
                            UnitPrice = 100m
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<short?>("AmountInStock")
                        .HasColumnName("AmountInStock");

                    b.Property<string>("ProductDescription")
                        .HasColumnName("ProductDescription")
                        .HasMaxLength(100);

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnName("UnitPrice")
                        .HasColumnType("decimal(19, 4)");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasName("UQ__Product__B40CC6CC5F2A0195");

                    b.ToTable("Product","dbo");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AmountInStock = (short)100,
                            ProductDescription = "A Book",
                            UnitPrice = 100m
                        },
                        new
                        {
                            ProductId = 2,
                            AmountInStock = (short)100,
                            ProductDescription = "Software",
                            UnitPrice = 200m
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Software", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<string>("LicenseCode")
                        .IsRequired()
                        .HasColumnName("LicenseCode")
                        .HasMaxLength(200);

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId")
                        .HasName("IX_ProductId");

                    b.ToTable("Software","dbo");

                    b.HasData(
                        new
                        {
                            ProductId = 2,
                            LicenseCode = "#1234567890"
                        });
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.BankAccount", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Customer", "Customer")
                        .WithMany("BankAccount")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.BankTransfers", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.BankAccount", "BankAccount")
                        .WithMany("BankTransfers")
                        .HasForeignKey("ToBankAccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Book", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Product", "Product")
                        .WithOne("Book")
                        .HasForeignKey("RepositoryEFDotnet.Data.Entity.Book", "ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Customer", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Country", "Country")
                        .WithMany("Customer")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Order", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.OrderDetails", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RepositoryEFDotnet.Data.Entity.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RepositoryEFDotnet.Data.Entity.Software", b =>
                {
                    b.HasOne("RepositoryEFDotnet.Data.Entity.Product", "Product")
                        .WithOne("Software")
                        .HasForeignKey("RepositoryEFDotnet.Data.Entity.Software", "ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}