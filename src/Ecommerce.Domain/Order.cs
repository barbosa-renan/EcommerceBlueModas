using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain
{
    public class Order
    {
        private Client _client;

        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;

                if(value!=null)
                    ClientId = value.Id;
            }
        }
        public List<OrderItem> Items { get; set; }
    }
}