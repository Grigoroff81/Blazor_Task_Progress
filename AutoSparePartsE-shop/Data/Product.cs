using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSparePartsE_shop.Data
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int AvailablePsc { get; set; }
        public DateTime AvailableOn { get; set; }
        public double ProductPrice { get; set; }
        public string ImagePath { get; set; }

    }
    
}
