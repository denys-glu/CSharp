using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class RegisterUser
    {

        [Key]
        public int UserID { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "At least 2 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "At least 2 Characters")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "At least 8 Characters")]
        // [PasswordValidation]
        public string Password { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "At least 8 Characters")]
        [Compare("Password", ErrorMessage = "Password should match")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}