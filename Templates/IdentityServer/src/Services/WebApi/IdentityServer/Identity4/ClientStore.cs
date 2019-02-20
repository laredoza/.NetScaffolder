using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.ApplicationService;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using IdentityServer4.Models;
using IdentityServer4.Stores;

namespace DotNetScaffolder.IdentityServer.Services.WebApi.IdentityServer.Identity4
{
    public class ClientStore : IClientStore
    {
        private IIdentityServerApplicationService applicationService;

        public ClientStore(IIdentityServerApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        private System.Collections.Generic.ICollection<string> ReturnGrantType(string grantType)
        {
            switch (grantType)
            {
                case "ClientCredentials":
                    return GrantTypes.ClientCredentials;
                    break;
                case "Code":
                    return GrantTypes.Code;
                    break; 
                case "CodeAndClientCredentials":
                    return GrantTypes.CodeAndClientCredentials;
                    break;
                case "DeviceFlow":
                    return GrantTypes.DeviceFlow;
                    break;
                case "Hybrid":
                    return GrantTypes.Hybrid;
                    break;
                case "HybridAndClientCredentials":
                    return GrantTypes.HybridAndClientCredentials;
                    break;
                case "Implicit":
                    return GrantTypes.Implicit;
                    break;
                case "ImplicitAndClientCredentials":
                    return GrantTypes.ImplicitAndClientCredentials;
                    break;
                case "ResourceOwnerPassword":
                    return GrantTypes.ResourceOwnerPassword;
                    break;
                case "ResourceOwnerPasswordAndClientCredentials":
                    return GrantTypes.ResourceOwnerPasswordAndClientCredentials;
                    break;
                default:
                    return null;
                    break;
            }
        }

        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            var foundClient = await this.applicationService.ReturnActiveTaskAsync(clientId);

            if (foundClient != null)
            {
                if (foundClient != null)
                {
                    Client client = new Client
                    {
                        ClientId = foundClient.ClientId,
                        ClientName = foundClient.ClientName,
                        AlwaysSendClientClaims = foundClient.AlwaysSendClientClaims,
                        AllowedGrantTypes = this.ReturnGrantType(foundClient.ClientGrantType.FirstOrDefault().GrantType.Name)
                    };

                    foreach (var clientGrantType in foundClient.ClientGrantType)
                    {
                        client.AllowedGrantTypes.Add(clientGrantType.GrantType.Name);
                    }

                    foreach (IAllowedScope allowedScope in foundClient.AllowedScope)
                    {
                        client.AllowedScopes.Add(allowedScope.ResourceName);
                    }

                    foreach (var postLogoutRedirectUri in foundClient.PostLogoutRedirectUri)
                    {
                        client.PostLogoutRedirectUris.Add(postLogoutRedirectUri.Uri);
                    }

                    foreach (var redirectUri in foundClient.RedirectUri)
                    {
                        client.RedirectUris.Add(redirectUri.Uri);
                    }

                    return client;
                }
            }

            return null;
        }
    }
}
