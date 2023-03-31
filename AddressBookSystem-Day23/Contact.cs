﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day23
{
    class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public override bool Equals(object obj)
        {
            Contacts contact = obj as Contacts;
            if (obj == null)
                return false;
            return this.FirstName.Equals(contact.FirstName) && this.LastName.Equals(contact.LastName);
        }
    }
}
