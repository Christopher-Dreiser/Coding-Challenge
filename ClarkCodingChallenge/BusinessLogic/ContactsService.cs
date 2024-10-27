using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.BusinessLogic
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
    }
}
