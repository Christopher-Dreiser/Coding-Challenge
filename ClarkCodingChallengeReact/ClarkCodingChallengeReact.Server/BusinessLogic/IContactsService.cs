using ClarkCodingChallengeReact.Server.Enum;
using ClarkCodingChallengeReact.Server.Models;

namespace ClarkCodingChallengeReact.Server.BusinessLogic
{
    public interface IContactsService
    {
        bool AddContact(Contact contact);

        IEnumerable<Contact> GetContacts(string lastName, SortDirection sortDirection);

        bool VerifyEmail(string email);
    }
}
