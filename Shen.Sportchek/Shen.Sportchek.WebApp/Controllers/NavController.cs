using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shen.Sportchek.Domain.Abstract;
using Shen.Sportchek.Domain.Concrete;

namespace Shen.Sportchek.WebApp.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public IProductsRepository ProductsRepository { get; set; }
          = new EFProductRepository();
        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = ProductsRepository
            .Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}