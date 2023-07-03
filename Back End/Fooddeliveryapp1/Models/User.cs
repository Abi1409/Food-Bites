using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Fooddeliveryapp1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? UserName { get; set; }
        public string Password { get; set; }       
        
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number")]
        [DataType(DataType.PhoneNumber)]
        public int Contact { get; set; }
        public DateTime RegisteredOn { get; set; }
        [Required]
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        //Navigations
        public Role Roles { get; set; }

    }
}
