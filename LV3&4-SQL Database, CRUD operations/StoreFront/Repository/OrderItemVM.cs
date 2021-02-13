using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderItemVM
    {
        public int OrderItemVMId { get; set; }
        public string OrderItemVMProductName { get; set; }
        public string OrderItemVMProductPackage { get; set; }
        public decimal OrderItemVMUnitPrice { get; set; }
        public int OrderItemVMQuantity { get; set; }
    }
}
