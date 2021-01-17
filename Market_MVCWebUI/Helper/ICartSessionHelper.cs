using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entity.DomainModels;

namespace Market_MVCWebUI.Helper
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key,Cart cart);
        void Clear();
    }
}
