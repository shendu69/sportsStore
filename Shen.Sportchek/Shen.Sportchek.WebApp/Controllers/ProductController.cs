using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shen.Sportchek.Domain.Abstract;
using Shen.Sportchek.Domain.Concrete;

namespace Shen.Sportchek.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }
          = new EFProductRepository();

        public int PageSize = 3;

       public ViewResult List(int page = 1)
        {
            var model = ProductsRepository
                .Products
                .OrderBy(p=>p.ProductID)
                .Skip((page-1) * PageSize)
                .Take(PageSize)
                ;

            return View(model);
                
        }
    }
}