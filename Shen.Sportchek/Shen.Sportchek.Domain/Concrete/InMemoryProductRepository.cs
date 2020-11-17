using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shen.Sportchek.Domain.Abstract;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.Domain.Concrete
{
    public class InMemoryProductRepository : IProductsRepository

    {
        private List<Product> _products = new List<Product>
        {
            new Product { Name = "Skates", Price = 100},
            new Product { Name = "Helmet", Price = 50},
            new Product { Name = "Gloves", Price = 30}
        };

        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }
}
