using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fooddeliveryapp1.DTO
{
    public class UpdateUserRequestDTO
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username must be between 1 and 50 characters.", MinimumLength = 1)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]

        [StringLength(60, ErrorMessage = "Password must be between 6 and 60 characters.", MinimumLength = 6)]

        public string Password { get; set; }
        
        public int Contact { get; set; }
        public DateTime RegisteredOn { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
    }
}
