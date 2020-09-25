using AARP.DTO;
using AARP.EF;
using AARP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AARP.Services.Implementation
{
    public class Module0Services : IModule0Services
    {
       readonly OSEntities obj;
        public Module0Services(OSEntities obj)
        {
            this.obj = obj;
        }
        public bool CreateCategory(AddCategoryVM model)
        {
            try
            {
                obj.Categories.Add(new Category
                {
                    CategoryName = model.CategoryName
                });
                if (obj.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
