using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fooddeliveryapp1.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? RoleName { get; set; }
    }
}
