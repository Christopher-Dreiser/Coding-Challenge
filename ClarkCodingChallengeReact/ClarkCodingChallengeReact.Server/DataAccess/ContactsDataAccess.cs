using ClarkCodingChallenge.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallengeReact.Server.DataAccess
{
    public class ContactsDataAccess
    {
        // TODO: Move to database for production use.
        private readonly List<Contact> _contacts;

        public void CreateContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public bool Exists(string email)
        {
            return _contacts.Any(c => c.Email == email);
        }
    }
}
