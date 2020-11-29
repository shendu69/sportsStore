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
            new Product { Name = "Skates", Price = 100.01m},
            new Product { Name = "Helmet", Price = 50.02m},
            new Product { Name = "Gloves", Price = 30.03m}
        };

        public IEnumerable<Product> Products
        {
            get { return _products; }
        }

        public Product DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
