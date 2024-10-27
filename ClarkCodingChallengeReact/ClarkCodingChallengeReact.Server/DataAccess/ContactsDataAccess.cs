﻿using ClarkCodingChallengeReact.Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallengeReact.Server.DataAccess
{
    public class ContactsDataAccess
    {
        // TODO: Move to database for production use.
        private readonly List<Contact> _contacts = new List<Contact>();

        public void CreateContact(Contact contact)
        {
            _contacts.Add(contact);
        }

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

        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }
    }
}
