using RepositoryEFDotnet.Data.ApplicationService;
using System;
using System.Collections.Generic;
using System.Text;
using StructureMap.Pipeline;

namespace RepositoryEFDotnet.Data.ApplicationServices.ApplicationService.Register
{
    public class ApplicationServiceRegistration : StructureMap.Registry
    {
        #region CTOR

        public ApplicationServiceRegistration()
        {
            this.For<IProductApplicationService>().LifecycleIs(Lifecycles.Unique).UseIfNone<ProductApplicationService>();
        }

        #endregion
    }
}
