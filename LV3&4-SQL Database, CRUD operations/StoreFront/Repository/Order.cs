using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int OrderCustomerId { get; set; }
        public decimal OrderTotalAmount { get; set; }
    }
}
