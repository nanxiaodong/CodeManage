﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
