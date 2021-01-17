using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.Concrete;

namespace Market_MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Category { get; set; }
        public int CurrentCategory { get; set; }
    }
}
