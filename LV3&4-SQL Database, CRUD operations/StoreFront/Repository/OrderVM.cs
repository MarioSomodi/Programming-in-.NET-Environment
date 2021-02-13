using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderVM
    {
        public int OrderVMId { get; set; }
        public string OrderVMNumber { get; set; }
        public DateTime OrderVMDate { get; set; }
        public decimal OrderVMTotalAmount { get; set; }
        public string OrderVMCustomerFullName { get; set; }
        public List<OrderItem> OrderVMItems { get; set; }
    }
}
