using System;
using System.Collections.Generic;
using System.Security.Claims;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using IdentityModel;
using Microsoft.EntityFrameworkCore;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Seed
{
    public static class MigrationHelper
    {
        public static void AddUsers(ModelBuilder modelBuilder)
        {
            Guid userId = Guid.NewGuid();

            modelBuilder.Entity<AspNetUserToken>().HasData(
                new AspNetUserToken
                {
                    LoginProvider = "IdentityServer4",
                    Name = "Alice",
                    UserId = userId,
                    Value = "Alice"
                });

            modelBuilder.Entity<AspNetUserLogin>().HasData(
                new AspNetUserLogin
                {
                    LoginProvider = "IdentityServer4",
                    ProviderKey = "IdentityServer4",
                    ProviderDisplayName = "IdentityServer4",
                    UserId = userId
                });

            modelBuilder.Entity<AspNetUserClaim>().HasData(
                new AspNetUserClaim
                {
                    Id = 1,
                    ClaimType = "name",
                    ClaimValue = "Alice",
                    UserId = userId
                });

            modelBuilder.Entity<AspNetUserClaim>().HasData(
                new AspNetUserClaim
                {
                    Id = 2,
                    ClaimType = "website",
                    ClaimValue = "https://alice.com",
                    UserId = userId
                });

            modelBuilder.Entity<AspNetUserClaim>().HasData(
                new AspNetUserClaim
                {
                    Id = 3,
                    ClaimType = "email",
                    ClaimValue = "alice@alice.com",
                    UserId = userId
                });

            modelBuilder.Entity<AspNetUserClaim>().HasData(
                new AspNetUserClaim
                {
                    Id = 4,
                    ClaimType = JwtClaimTypes.Role,
                    ClaimValue = "User",
                    UserId = userId
                });

            modelBuilder.Entity<AspNetUser>().HasData(
                new AspNetUser
                {
                    Id = userId,
                    AccessFailedCount = 0,
                    UserName = "Alice",
                    NormalizedUserName = "alice",
                    AspNetUserRole = new List<AspNetUserRole>(),
                    Email = "alice@alice.com",
                    NormalizedEmail = "alice@alice.com",
                    EmailConfirmed = true,
                    PasswordHash = "password",
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumber = "123#",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,

                });
        }

        private static void AddClient(ModelBuilder modelBuilder, int id, string name)
        {
            modelBuilder.Entity<GrantType>().HasData(
                new GrantType
                {
                    Id = id,
                    Name = name
                });
        }

        private static void AddScope(ModelBuilder modelBuilder, int id, int clientId, string name)
        {
            modelBuilder.Entity<AllowedScope>().HasData(
                new AllowedScope
                {
                    Id = id,
                    ClientId = clientId,
                    ResourceName = name
                });
        }

        public static void AddClients(ModelBuilder modelBuilder)
        {
            int grantId = 1;
            AddClient(modelBuilder, grantId, "ClientCredentials");

            grantId++;
            AddClient(modelBuilder, grantId, "Code");

            grantId++;
            AddClient(modelBuilder, grantId, "CodeAndClientCredentials");

            grantId++;
            AddClient(modelBuilder, grantId, "DeviceFlow");

            grantId++;
            AddClient(modelBuilder, grantId, "Hybrid");

            grantId++;
            AddClient(modelBuilder, grantId, "HybridAndClientCredentials");

            grantId++;
            AddClient(modelBuilder, grantId, "Implicit");

            grantId++;
            AddClient(modelBuilder, grantId, "ImplicitAndClientCredentials");

            grantId++;
            AddClient(modelBuilder, grantId, "ResourceOwnerPassword");

            grantId++;
            AddClient(modelBuilder, grantId, "ResourceOwnerPasswordAndClientCredentials");

            int clientId = 1;

            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = clientId,
                    ClientId = "mvc",
                    ClientName = "MVC client",
                    AlwaysSendClientClaims = true,
                    Active = true
                });

            modelBuilder.Entity<ClientGrantType>().HasData(
                new ClientGrantType
                {
                    ClientId = clientId,
                    GrantTypeId = 5
                });

            int allowedScopeId = 1;
            AddScope(modelBuilder, allowedScopeId, clientId, "openid");

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "profile");

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "email");

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "roles");

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "api1");

            int rediectUriId = 1;

            modelBuilder.Entity<RedirectUri>().HasData(
                new RedirectUri 
                {
                    Id = rediectUriId,
                    ClientId = clientId,
                    Uri = "http://localhost:5002/signin-oidc"
                });
            
            int postRediectUriId = 1;
            modelBuilder.Entity<PostLogoutRedirectUri>().HasData(
                new PostLogoutRedirectUri 
                {
                    Id = postRediectUriId,
                    ClientId = clientId,
                    Uri = "http://localhost:5002/signout-callback-oidc"
                });

            //int scopeId = 1;
            //modelBuilder.Entity<AllowedScope>().HasData(
            //    new AllowedScope 
            //    {
            //        Id = scopeId,
            //        ClientId = clientId,
            //        ResourceName = IdentityServerConstants.StandardScopes.OpenId,
            //    });

            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        ProductId = 1,
            //        ProductDescription = "A Book",
            //        UnitPrice = 100,
            //        AmountInStock = 100
            //    });

            //modelBuilder.Entity<Software>().HasData(
            //    new Software
            //    {
            //        ProductId = 2,
            //        LicenseCode = "#1234567890"
            //    });

            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        ProductId = 2,
            //        ProductDescription = "Software",
            //        UnitPrice = 200,
            //        AmountInStock = 100
            //    });
        }

        public static void AddCustomers(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerId = 1,
            //        CustomerCode = "001",
            //        CompanyName = "New York Books",
            //        ContactName = "Bob",
            //        ContactTitle = "Mr",
            //        Address = "1st Road",
            //        City = "New York",
            //        PostalCode = "001",
            //        Telephone = "123456789",
            //        Fax = "123456789",
            //        CountryId = 1,
            //        Photo = "",
            //        IsEnabled = true
            //    });

            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerId = 2,
            //        CustomerCode = "002",
            //        CompanyName = "London Software",
            //        ContactName = "Mary",
            //        ContactTitle = "Miss",
            //        Address = "2nd Road",
            //        City = "London",
            //        PostalCode = "002",
            //        Telephone = "0123456789",
            //        Fax = "0123456789",
            //        CountryId = 2,
            //        Photo = "",
            //        IsEnabled = true
            //    });
        }

        public static void AddBanking(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BankAccount>().HasData(
            //    new BankAccount
            //    {
            //        BankAccountId = 1,
            //        BankAccountNumber = "001",
            //        Balance = 10000,
            //        CustomerId = 1,
            //        Locked = false
            //    });

            //modelBuilder.Entity<BankAccount>().HasData(
            //    new BankAccount
            //    {
            //        BankAccountId = 2,
            //        BankAccountNumber = "002",
            //        Balance = 20000,
            //        CustomerId = 2,
            //        Locked = false
            //    });

            //modelBuilder.Entity<BankTransfers>().HasData(
            //    new BankTransfers
            //    {
            //        BankTransferId = 1,
            //        FromBankAccountId = 1,
            //        ToBankAccountId = 2,
            //        Amount = 100,
            //        TransferDate = DateTime.Now
            //    });


        }

        public static void AddOrders(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>().HasData(
            //    new Order
            //    {
            //        OrderId = 1,
            //        CustomerId = 2,
            //        OrderDate = DateTime.Now,
            //        DeliveryDate = DateTime.Now,
            //        ShippingName = "Mary",
            //        ShippingAddress = "2nd road",
            //        ShippingCity = "London",
            //        ShippingZip = "123"
            //    });

            //modelBuilder.Entity<OrderDetails>().HasData(
            //    new OrderDetails
            //    {
            //        OrderDetailsId = 1,
            //        OrderId = 1,
            //        ProductId = 1,
            //        UnitPrice = 100,
            //        Amount = 100,
            //        Discount = 0
            //    });
        }
    }
}
