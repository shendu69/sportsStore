using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.WebApp.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}