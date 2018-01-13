﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.DTO
{
  public  class ProductDto
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
