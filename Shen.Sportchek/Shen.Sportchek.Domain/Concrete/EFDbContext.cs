﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products {get; set; }
    }
}
