using System;
using System.Collections.Generic;
using System.Security.Claims;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using IdentityModel;
using Microsoft.EntityFrameworkCore;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Seed
{
    public static class MigrationHelper
    {
        public static void AddUsers(ModelBuilder modelBuilder)
        {
            Guid userId = Guid.NewGuid();
            IPasswordHasher<AspNetUser> passwordHasher = new PasswordHasher<AspNetUser>();

            int roleId = 1;
            Guid adminRoleId = Guid.NewGuid();

            modelBuilder.Entity<AspNetRole>().HasData(
                new AspNetRole 
                {
                    Id = adminRoleId, 
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = DateTime.Now.ToString()
                });

            Guid userRoleId = Guid.NewGuid();

            modelBuilder.Entity<AspNetRole>().HasData(
                new AspNetRole 
                {
                    Id = userRoleId, 
                    Name = "User",
                    NormalizedName = "user",
                    ConcurrencyStamp = DateTime.Now.ToString()
                });

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

            var user = new AspNetUser
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
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "password");
            modelBuilder.Entity<AspNetUser>().HasData(user);

            modelBuilder.Entity<AspNetUserRole>().HasData(
                new AspNetUserRole 
                {
                    UserId = userId,
                    RoleId = adminRoleId
                });
        }

        private static void AddGrant(ModelBuilder modelBuilder, int id, string name)
        {
            modelBuilder.Entity<DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.GrantType>().HasData(
                new DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.GrantType
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

        private static void AddClientSecret(ModelBuilder modelBuilder, int id, int clientId, string secret)
        {
            modelBuilder.Entity<ClientSecret>().HasData(
                new ClientSecret 
                {
                    Id = id,
                    ClientId = clientId,
                    Secret = secret
                });
        }

        public static void AddClients(ModelBuilder modelBuilder)
        {
            int grantId = 1;
            AddGrant(modelBuilder, grantId, "ClientCredentials");

            grantId++;
            AddGrant(modelBuilder, grantId, "Code");

            grantId++;
            AddGrant(modelBuilder, grantId, "CodeAndClientCredentials");

            grantId++;
            AddGrant(modelBuilder, grantId, "DeviceFlow");

            grantId++;
            AddGrant(modelBuilder, grantId, "Hybrid");

            grantId++;
            AddGrant(modelBuilder, grantId, "HybridAndClientCredentials");

            grantId++;
            AddGrant(modelBuilder, grantId, "Implicit");

            grantId++;
            AddGrant(modelBuilder, grantId, "ImplicitAndClientCredentials");

            grantId++;
            AddGrant(modelBuilder, grantId, "ResourceOwnerPassword");

            grantId++;
            AddGrant(modelBuilder, grantId, "ResourceOwnerPasswordAndClientCredentials");

            // Add Hybrid MVC Client
            int clientId = 1;

            modelBuilder.Entity<DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client>().HasData(
                new DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client
                {
                    Id = clientId,
                    ClientId = "mvc",
                    ClientName = "MVC Hybrid Client",
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

            int secretId = 1;
            AddClientSecret(modelBuilder, secretId, clientId, "secret".Sha256());

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
            
            // Add Api Client
            clientId++;

            modelBuilder.Entity<DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client>().HasData(
                new DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client
                {
                    Id = clientId,
                    ClientId = "client",
                    ClientName = "Api Client",
                    AlwaysSendClientClaims = true,
                    Active = true
                });

            modelBuilder.Entity<ClientGrantType>().HasData(
                new ClientGrantType
                {
                    ClientId = clientId,
                    GrantTypeId = 1
                });

            secretId++;
            AddClientSecret(modelBuilder, secretId, clientId, "secret".Sha256());

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "api1");

            // Add Console Client 
            clientId++;

            modelBuilder.Entity<DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client>().HasData(
                new DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity.Client
                {
                    Id = clientId,
                    ClientId = "ro.client",
                    ClientName = "Console Client",
                    AlwaysSendClientClaims = true,
                    Active = true
                });

            modelBuilder.Entity<ClientGrantType>().HasData(
                new ClientGrantType
                {
                    ClientId = clientId,
                    GrantTypeId = 9
                });

            secretId++;
            AddClientSecret(modelBuilder, secretId, clientId, "secret".Sha256());

            allowedScopeId++;
            AddScope(modelBuilder, allowedScopeId, clientId, "api1");
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
