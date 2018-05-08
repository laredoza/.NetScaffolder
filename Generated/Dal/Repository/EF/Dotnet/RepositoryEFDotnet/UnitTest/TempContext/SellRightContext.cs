using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    using System.Data.Entity;

    using MySql.Data.Entity;

    using RepositoryEFDotnet.UnitTest.TempContext;

    // Code-Based Configuration and Dependency resolution  
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class SellRightContext : DbContext
    {
        //Add your Dbsets here  
        public DbSet<Product> Products
        {
            get;
            set;
        }

        public SellRightContext()
            //Reference the name of your connection string  
            : base("SellRightDb") { }
    }
}
