using System.Collections.Generic;

namespace Ecommerce.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}