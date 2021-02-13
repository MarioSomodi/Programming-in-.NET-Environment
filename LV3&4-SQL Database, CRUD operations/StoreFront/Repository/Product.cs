using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductSupplierId { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public string ProductPackage { get; set; }
        public bool ProductIsDiscontinued { get; set; }
    }
}
