﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{public enum ProductCategorys
    {
        Food,
        AppLiances
    }
    public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }
    }
}
