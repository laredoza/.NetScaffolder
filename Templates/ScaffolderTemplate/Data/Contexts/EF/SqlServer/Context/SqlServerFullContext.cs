using SqlServer.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models.Context.EF
{
    [DbConfigurationType(typeof(SqlServerConfiguration))]
    public partial class SqlServerFullContext
    {
    }
}
