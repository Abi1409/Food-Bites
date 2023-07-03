using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fooddeliveryapp1.Models
{
    public class Cart
    {
        [Key]
        public int CartOrderId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        [Required]
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        //navigations
        public User Users { get; set; }
        public Item Items { get; set; }
    }
}
