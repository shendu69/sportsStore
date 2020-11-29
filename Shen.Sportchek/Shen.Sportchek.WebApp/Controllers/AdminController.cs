﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shen.Sportchek.Domain.Abstract;
using Shen.Sportchek.Domain.Concrete;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.WebApp.Controllers
{
    public class AdminController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }
          = new EFProductRepository();

        public ViewResult Edit(int productId)
        {
            Product product = ProductsRepository
            .Products
            .FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductsRepository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

    }
}