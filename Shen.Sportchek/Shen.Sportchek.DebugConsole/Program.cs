using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shen.Sportchek.Domain.Concrete;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                for (int i =0; i< 10; i++)
                {
                    var product = new Product()
                    {
                        Name = $"Skates_{i}",
                        Price = 100.01m,
                        Description = "This is figure skates",
                        Category = "Skating"
                    };

                    ctx.Products.Add(product);
                }
                ctx.SaveChanges();
            }

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
