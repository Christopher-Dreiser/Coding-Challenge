using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ClarkCodingChallengeReact.Server.Models
{
    [BindProperties]
    public class Contact
    {
        [Required(ErrorMessage = "First Name cannot be empty")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        public required string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Email must be a valid email address.")]
        public required string Email { get; set; }
    }
}
