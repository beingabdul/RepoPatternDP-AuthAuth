using AARP.EF;
using AARP.Services.Implementation;
using AARP.Services.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AARP.Services
{
    public class ServiceRegistration
    {
        public static void BindAll(IKernel kernel)
        {
            kernel.Bind<IModule0Services>().To<Module0Services>();
            kernel.Bind<OSEntities>().ToSelf();
        }
    }
}
