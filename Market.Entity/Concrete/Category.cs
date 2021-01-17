﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Abstract;

namespace Market.Entity.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
