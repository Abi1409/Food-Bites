using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Fooddeliveryapp1.DTO
{

    public class UserDto
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is required")]
        [DataType(DataType.Password)]

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }
        public string Email { get; set; }
        
        public string Contact { get; set; }
        public DateTime RegisteredOn { get; set; }
        [Required]
        [ForeignKey(nameof(RoleDto))]
        public int RoleId { get; set; }

        //Navigations
        public RoleDto Roles { get; set; }

    }
}
