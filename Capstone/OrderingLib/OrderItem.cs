using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class OrderItem
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int orderId { get; set; }

        public int quantity { get; set; }

        public OrderItem()
        {
            id = Globals.orderItems.Count + 1;
        }
    }
}
