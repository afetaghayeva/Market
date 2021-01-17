using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Business.Abstract;
using Market_MVCWebUI.Models;

namespace Market_MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model=new ProductListViewModel
            {
                Product = category>0?_productService.GetByCategoryId(category):_productService.GetAll()
            };
            return View(model);
        }
    }
}
