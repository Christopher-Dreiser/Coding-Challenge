using ClarkCodingChallengeReact.Server.Models;

namespace ClarkCodingChallengeReact.Server.DataAccess
{
    public interface IContactsRepository
    {
        bool Exists(string email);

        bool AddContact(Contact contact);

        IEnumerable<Contact> GetContacts(string lastName);
    }
}
