using System.ComponentModel.DataAnnotations;
namespace FormSubmission
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage="A tiny bit longer")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4, ErrorMessage="You can do better")]
        public string LastName { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity, ErrorMessage="TRY HARDER")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}