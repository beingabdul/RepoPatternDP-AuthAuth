using AARP.Services;
using AARP.UOW.Implementation;
using AARP.UOW.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AARP.UOW
{
    public class UOWRegistration
    {
        public static IKernel GlobelKernal { get; private set; }
        public static void BindAll(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            ServiceRegistration.BindAll(kernel);
            GlobelKernal = kernel;
        }
    }
}
