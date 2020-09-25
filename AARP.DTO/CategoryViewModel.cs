using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AARP.DTO
{
    public class AddCategoryVM
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
