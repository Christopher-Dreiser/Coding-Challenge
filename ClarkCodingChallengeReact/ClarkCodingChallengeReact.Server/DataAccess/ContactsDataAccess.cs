using ClarkCodingChallengeReact.Server.Models;

namespace ClarkCodingChallengeReact.Server.DataAccess
{
    public class ContactsDataAccess : IContactsRepository
    {
        // TODO: Move to database for production use.
        private readonly List<Contact> _contacts = new List<Contact>();

        public bool Exists(string email)
        {
            return _contacts.Any(c => c.Email == email);
        }

        public bool AddContact(Contact contact)
        {
            if (_contacts.Contains(contact))
            {
                return false;
            }

            _contacts.Add(contact);
            return true;
        }

        public IEnumerable<Contact> GetContacts(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return _contacts;
            }

            return _contacts.Where(c => c.LastName.Equals(lastName, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
