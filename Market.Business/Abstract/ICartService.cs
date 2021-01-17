using System;
using System.Collections.Generic;
using System.Text;
using Market.Entity.Concrete;
using Market.Entity.DomainModels;

namespace Market.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Product product, Cart cart);
        void DeleteFromCart(Product product, Cart cart);
    }
}
