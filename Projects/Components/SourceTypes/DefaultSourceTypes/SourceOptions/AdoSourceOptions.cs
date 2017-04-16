using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions
{
    public class AdoSourceOptions
    {
        public string ConnectionString { get; set; }

        public string ProviderName { get; set; }

        public AdoSourceOptions()
        {
            this.ProviderName = "System.Data.SqlClient";
            this.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=AutoNLayered";
        }
    }
}
