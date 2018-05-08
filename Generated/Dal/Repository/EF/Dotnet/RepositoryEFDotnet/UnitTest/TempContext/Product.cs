using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest.TempContext
{
    public class Product
    {
        public int ProductId
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
    }
}
