using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.DomainModels;

namespace Market.MVCWebUI.Helper
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void Clear();
        void SetCart(string key, Cart cart);
    }
}
