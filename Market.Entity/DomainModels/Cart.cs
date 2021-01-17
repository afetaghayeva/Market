using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entity.Abstract;

namespace Market.Entity.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartItems=new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return CartItems.Sum(c => c.Product.UnitPrice * c.Quantity);
            }
        }
    }
}
