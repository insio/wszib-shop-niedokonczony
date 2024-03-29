﻿using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Repositories
{
   public interface IProductRepository
    {
        Product Get(Guid Id);
        IEnumerable<Product> GetAll();
        void Add(Product product);
    }
}
