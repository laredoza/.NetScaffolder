using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.Core
{
    public class GenerationValidation
    {
        bool InvalidPrecision(object type)
        {
            if (type is Int16 || type is Int32)
            {
                return true;
            }

            return false;
        }
    }
}
