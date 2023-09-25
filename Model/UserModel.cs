using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtos_API_ASP.NET.Model
{
    [Table("User")]
    public class UserModel
    {
        [Key]
        public int Id { get; set; }


        [Column("name")]
        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column ("email")]
        [Display(Name = "email")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Column("password")]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$", ErrorMessage = "Password must contain at least 8 characters, including at least one letter, one number, and one special character.")]
        public string Password { get; set; }


        [Column("username")]
        [Display(Name = "UserName")]
        [MaxLength(255)]
        public string Username { get; set; }

        [Column("role")]
        [Display(Name = "Role")]
        public string Role { get; set; }
    }
}
