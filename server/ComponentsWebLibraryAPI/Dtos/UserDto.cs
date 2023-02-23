using System.ComponentModel.DataAnnotations;
using ComponentsWebLibraryAPI.Models;

namespace ComponentsWebLibraryAPI.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Email field is required")]
        [EmailAddress(ErrorMessage = "Please enter valid e-mail")]
        [RegularExpression(pattern: @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$", 
            ErrorMessage = "Please enter valid e-mail")]
        public string Email { get; set; }
        
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Name can contain only letters")]
        public string? FirstName { get; set; }
        
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Last name can contain only letters")]
        public string? LastName { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Password has to be 8 symbols minimum")]
        public string? Password { get; set; }
    }
}
