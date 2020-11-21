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
       public ViewResult List()
        {
            return View(ProductsRepository.Products);
        }
    }
}