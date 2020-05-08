using System;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LoginUser
    {

        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [MinLength(8)]
        public string LoginPassword { get; set; }

    }
}