using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderItemOrderId { get; set; }
        public int OrderItemProductId { get; set; }
        public decimal OrderItemUnitPrice { get; set; }
        public int OrderItemQuantity { get; set; }
    }
}
