using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.business.Abstract;
using avm.entity;
using Microsoft.AspNetCore.Mvc;

namespace avm.webui.Controllers
{
    public class HomeController :Controller
    {
         private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }
        
        public IActionResult Index()
        {                                      
                   var   product      =  new List<Product>();
             product = _productService.GetAll();
            
            return View(product);
        }

        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}