using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;

namespace RepositoryEFDotnet.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API"),
                //new IdentityResources.OpenId(),
                //new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            IdentityResource rolesResource = new IdentityResource
            {
                Name = "roles",
                DisplayName = "Roles",
                Description = "Allow the service access to your user roles.",
                UserClaims = new[] { JwtClaimTypes.Role, ClaimTypes.Role },
                ShowInDiscoveryDocument = true,
                Required = true,
                Emphasize = true
            };

            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                rolesResource
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                 // OpenID Connect implicit flow client (MVC)
        new Client
        {
            ClientId = "mvc",
            ClientName = "MVC Client",
            AllowedGrantTypes = GrantTypes.Implicit,

            // where to redirect to after login
            RedirectUris = { "http://localhost:5002/signin-oidc" },

            // where to redirect to after logout
            PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },

            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Email,
                "roles"
            },
            AlwaysSendClientClaims = true
            // https://github.com/IdentityServer/IdentityServer4/issues/1786
        },
                new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "api1" }
            },
                // resource owner password grant client
        new Client
        {
            ClientId = "ro.client",
            AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },
            AllowedScopes = { "api1" }
        }
        };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
    {
       new TestUser
        {
            SubjectId = "1",
            Username = "alice",
            Password = "password",

            Claims = new []
            {
                new Claim("name", "Alice"),
                new Claim("website", "https://alice.com"),
                new Claim("email", "alice@alice.com"),
                new Claim(JwtClaimTypes.Role, "User")
        }
        },
        new TestUser
        {
            SubjectId = "2",
            Username = "bob",
            Password = "password",

            Claims = new []
            {
                new Claim("name", "Bob"),
                new Claim("website", "https://bob.com"),
                new Claim("email", "bob@bob.com"),
                new Claim(JwtClaimTypes.Role, "Admin")
            }
        }
    };
        }
    }
}
