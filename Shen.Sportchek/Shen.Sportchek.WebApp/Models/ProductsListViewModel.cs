﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.WebApp.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}