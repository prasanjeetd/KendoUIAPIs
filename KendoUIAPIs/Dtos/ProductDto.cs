﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIAPIs.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        //public int SupplierId { get; set; }

        //public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        //public int UnitsInStock { get; set; }

        //public int UnitsOnOrder { get; set; }

        //public int ReorderLevel { get; set; }

        //public bool Discontinued { get; set; }

        //public CategoryDto Category { get; set; }
    }
}