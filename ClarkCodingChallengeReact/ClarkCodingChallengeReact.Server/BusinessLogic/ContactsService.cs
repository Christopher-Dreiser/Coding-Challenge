using ClarkCodingChallengeReact.Server.Models;
using ClarkCodingChallengeReact.Server.DataAccess;
using ClarkCodingChallengeReact.Server.Enum;

namespace ClarkCodingChallengeReact.Server.BusinessLogic
{
    public class ContactsService : IContactsService
    {
        private readonly IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public bool VerifyEmail(string email)
        {
            return !_contactsRepository.Exists(email);
        }

        public bool AddContact(Contact contact)
        {
            return _contactsRepository.AddContact(contact);
        }

        public IEnumerable<Contact> GetContacts(string lastName, SortDirection sortDirection)
        {
            var results = _contactsRepository.GetContacts(lastName);

            if (sortDirection == SortDirection.Ascending)
            {
                return results.OrderBy(r => r.LastName).ThenBy(r => r.FirstName);
            }
            return results.OrderByDescending(r => r.LastName).ThenByDescending(r => r.FirstName);
        }
    }
}
