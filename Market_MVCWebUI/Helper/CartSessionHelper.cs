﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.DomainModels;
using Market_MVCWebUI.Extensions;
using Microsoft.AspNetCore.Http;

namespace Market_MVCWebUI.Helper
{
    public class CartSessionHelper:ICartSessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetCart(string key, Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, cart);
        }

        public Cart GetCart(string key)
        {
            var cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            if (cartToCheck==null)
            {
                SetCart(key,new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            }

            return cartToCheck;
        }

        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }
    }
}
