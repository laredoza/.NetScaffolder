using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryEFDotnet.Contexts.NHibernate.SqlServer.Mappings
{
    using Banking.Models.Entity;

    using FluentNHibernate.Mapping;

    public class BankAccountMap : ClassMap<BankAccount>
    {
        public BankAccountMap()
        {
            this.Id(x => x.BankAccountId);
            this.Map(x => x.Balance);
            this.Map(x => x.BankAccountNumber);
            this.Map(x => x.Locked);
        }
    }
}
