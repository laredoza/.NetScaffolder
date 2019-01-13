using System;
using System.Collections.Generic;
using System.Text;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Core
{
    public class WebApiSettings : IWebApiSettings
    {
        public string BasePath { get; set; }
    }
}
