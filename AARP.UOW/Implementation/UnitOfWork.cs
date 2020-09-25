using AARP.Services.Interface;
using AARP.UOW.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AARP.UOW.UOWRegistration;
namespace AARP.UOW.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public IModule0Services Service => GlobelKernal.Get<IModule0Services>();
    }
}
