using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
    }
}
