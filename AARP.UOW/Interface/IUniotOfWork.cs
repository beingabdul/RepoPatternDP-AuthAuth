using AARP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AARP.UOW.Interface
{
    public interface IUnitOfWork
    {
        IModule0Services Service { get; }
    }
}
