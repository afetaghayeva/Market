﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.Concrete;

namespace Market.MVCWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int CurrentCategoryId { get; set; }
    }
}
