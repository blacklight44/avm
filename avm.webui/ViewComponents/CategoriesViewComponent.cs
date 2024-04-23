using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using avm.business.Abstract;

namespace avm.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService=categoryService;
        }
        public IViewComponentResult Invoke()
        {
            //  if (RouteData.Values["action"].ToString()=="list")
            //     ViewBag.SelectedCategory = RouteData?.Values["id"];
            if (RouteData.Values["category"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
                var c = _categoryService.GetAll();
                
            // return View(_categoryService.GetAll());
            return View("~/Views/Shared/Components/Categories/Default.cshtml", c);
        }
    }

    // public class CategoriesViewComponent:ViewComponent
    // {
    //     public IViewComponentResult Invoke()
    //     {
    //         var categories = new List<Category>()
    //         {
    //             new Category {Name="Telefon",Description="Telefon Kategorisi"},
    //             new Category {Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
    //             new Category {Name="Elektronik",Description="Elektronik Kategorisi"}
    //         };

    //         return View(categories);
    //     }
    // }
}