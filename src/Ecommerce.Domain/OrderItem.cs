using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain
{
    public class OrderItem
    {
        private Product _product;
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;

                if(value !=null)
                    ProductId = value.Id;
            }
        }
    }
}