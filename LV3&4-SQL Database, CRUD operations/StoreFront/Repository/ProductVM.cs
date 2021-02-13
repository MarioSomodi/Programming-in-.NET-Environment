using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductVM
    {
        public int ProductVMId { get; set; }
        public string ProductVMName { get; set; }
        public string ProductVMSupplierName { get; set; }
        public decimal ProductVMUnitPrice { get; set; }
        public string ProductVMPackage { get; set; }
        public bool ProductVMIsDiscontinued { get; set; }
    }
}
