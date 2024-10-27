using ClarkCodingChallengeReact.Server.Models;
using ClarkCodingChallengeReact.Server.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallengeReact.Server.BusinessLogic
{
    public class ContactsService
    {
        private readonly ContactsDataAccess _contactsAccess;

        public ContactsService(ContactsDataAccess contactsDataAccess)
        {
            _contactsAccess = contactsDataAccess;
        }

        public bool VerifyEmail(string email)
        {
            return !_contactsAccess.Exists(email);
        }

        public bool AddContact(Contact contact)
        {
            return _contactsAccess.AddContact(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contactsAccess.GetContacts();
        }
    }
}
