using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ClarkCodingChallenge.DTO
{
    [BindProperties]
    public class Contact
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Remote(action: "VerifyEmail", controller: "ContactsController")]
        public string Email { get; set; }
    }
}
