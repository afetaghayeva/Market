using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Business.Abstract;
using Market.Entity.Concrete;
using Market_MVCWebUI.Helper;
using Market_MVCWebUI.Models;
using Market_MVCWebUI.ValidationRules.FluentValidation;

namespace Market_MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IProductService _productService;
        private readonly ICartSessionHelper _cartSessionHelper;

        public CartController(ICartService cartService, IProductService productService, ICartSessionHelper cartSessionHelper)
        {
            _cartService = cartService;
            _productService = productService;
            _cartSessionHelper = cartSessionHelper;
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(product,cart);
            _cartSessionHelper.SetCart("cart",cart);
            TempData.Add("message",product.ProductName+" Added!");
            return RedirectToAction("Index","Product");
        }

        public IActionResult RemoveToCart(int productId)
        {
            var product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.DeleteFromCart(product,cart);
            _cartSessionHelper.SetCart("cart",cart);
            TempData.Add("message", product.ProductName + " Deleted!");
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "Your order has been successfully completed");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
        }
    }
}
