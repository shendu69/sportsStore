using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shen.Sportchek.Domain.Abstract;
using Shen.Sportchek.Domain.Concrete;
using Shen.Sportchek.WebApp.Models;

namespace Shen.Sportchek.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }
          = new EFProductRepository();

        public int PageSize = 3;

        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = ProductsRepository
                    .Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepository
                    .Products
                    .Where(p => category == null || p.Category == category)
                    .Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}