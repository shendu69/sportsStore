﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shen.Sportchek.Domain.Entities;

namespace Shen.Sportchek.Domain.Abstract
{
    interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
