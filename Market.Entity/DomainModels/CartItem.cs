using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Abstract;
using Market.Entity.Concrete;

namespace Market.Entity.DomainModels
{
    public class CartItem:IDomainModel
    {
        public Product Product { get; set; }
        public int  Quantity { get; set; }
    }
}
