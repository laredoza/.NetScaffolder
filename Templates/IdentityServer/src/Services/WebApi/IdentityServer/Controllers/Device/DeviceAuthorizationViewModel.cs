// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using DotNetScaffolder.Domain.Services.WebApi.IdentityServer.Controllers.Consent;

namespace DotNetScaffolder.Domain.Services.WebApi.IdentityServer.Controllers.Device
{
    public class DeviceAuthorizationViewModel : ConsentViewModel
    {
        public string UserCode { get; set; }
        public bool ConfirmUserCode { get; set; }
    }
}