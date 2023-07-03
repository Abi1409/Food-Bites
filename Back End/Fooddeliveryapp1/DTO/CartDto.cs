using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fooddeliveryapp1.DTO
{
    public class CartDto
    {
        [Key]
        public int CartOrderId { get; set; }

        [Required]
        [ForeignKey(nameof(UserDto))]
        public int UserId { get; set; }
        [Required]
        [ForeignKey(nameof(ItemDto))]
        public int ItemId { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        //navigations
        //public UserDto Users { get; set; }
        //public ItemDto Items { get; set; }
    }
}
