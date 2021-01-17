using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Market.Business.Abstract;
using Market.Entity.Concrete;
using Market.Entity.DomainModels;

namespace Market.Business.Concrete
{
    public class CartManager:ICartService
    {
        public void AddToCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartItem!=null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cart.CartItems.Add(new CartItem{Product = product,Quantity = 1});
            }
            
        }

        public void DeleteFromCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartItem!=null)
            {
                cart.CartItems.Remove(cartItem);
            }
        }
    }
}
