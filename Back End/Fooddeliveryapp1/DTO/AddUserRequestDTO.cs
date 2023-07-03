using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Fooddeliveryapp1.Models;

namespace Fooddeliveryapp1.DTO
{
    public class AddUserRequestDTO 
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string? Password { get; set; }

       
        public int Contact { get; set; }
        public DateTime RegisteredOn { get; set; }



        
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }



       /* public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new AddUserRequestValidator();
            var validationResult = validator.Validate(this);
            return validationResult.Errors.Select(error => new ValidationResult(error.ErrorMessage, new[] { error.PropertyName }));
        }*/
    }
}
