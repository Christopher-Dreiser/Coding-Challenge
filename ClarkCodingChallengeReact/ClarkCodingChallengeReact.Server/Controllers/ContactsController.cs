using ClarkCodingChallengeReact.Server.BusinessLogic;
using ClarkCodingChallengeReact.Server.Enum;
using ClarkCodingChallengeReact.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallengeReact.Server.Controllers
{
    [ApiController]
    [Route("Contacts")]
    public partial class ContactsController : ControllerBase
    {
        private readonly IContactsService _contactsService;

        public ContactsController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        [HttpPost("")]
        public IActionResult CreateContact([FromBody]Contact contact)
        {
            var validationResult = ValidateUserInfo(contact);

            if (!validationResult.IsValid)
            {
                return BadRequest($"The following error(s) have occurred: {string.Join(", ", validationResult.Messages)}");
            }

            if (!_contactsService.AddContact(contact))
            {
                return BadRequest("An error occured while attempting to save the contact.");
            }

            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetContacts(string lastName = "", SortDirection sortDirection = SortDirection.Descending)
        {
            return Ok(_contactsService.GetContacts(lastName, sortDirection));
        }

        private ValidationResult ValidateUserInfo(Contact contact)
        {
            var results = new ValidationResult();

            // Validate email
            if (!_contactsService.VerifyEmail(contact.Email))
            {
                results.AddValidationError("Email is already in use.");
            }

            // Validate first name
            if (string.IsNullOrWhiteSpace(contact.FirstName))
            {
                results.AddValidationError("First Name cannot be empty");
            }

            // Validate last name
            if(string.IsNullOrWhiteSpace(contact.LastName))
            {
                results.AddValidationError("Last Name cannot be empty");
            }

            return results;
        }
    }
}
