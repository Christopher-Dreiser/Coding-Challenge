using ClarkCodingChallengeReact.Server.Models;

namespace ClarkCodingChallengeReact.Server.BusinessLogic
{
    public interface IContactsService
    {
        bool AddContact(Contact contact);

        IEnumerable<Contact> GetContacts();

        bool VerifyEmail(string email);
    }
}
