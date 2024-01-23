using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GrantTest.Models;

public class User
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [DisplayName("Full Name")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Login is required")]
    [DisplayName("User Login")]
    public required string Login { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    public required string Password { get; set; }
}
