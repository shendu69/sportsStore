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
    [Authorize]
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
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                }
                ProductsRepository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = ProductsRepository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }

    }
}