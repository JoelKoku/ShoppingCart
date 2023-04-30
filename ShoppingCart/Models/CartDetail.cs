using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int ID { get; set; }
        [Required]
        public int ShopingCartId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public Book Book { get; set; }
        public ShopingCart ShopingCart { get; set; }

    }
}
