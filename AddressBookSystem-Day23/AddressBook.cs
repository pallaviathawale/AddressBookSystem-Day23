using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day23
{

    internal class AddressBooks
    {

        List<Contact> addressBookList = new List<Contact>();

        public void CreateContact()
        {
            Contact contacts = new Contact();

            Console.WriteLine("Enter First Name : ");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            contacts.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            contacts.ZipCode = Console.ReadLine();
            Console.WriteLine("Contact created successfully......");
        }
        public void AddContact()
        {
            Contact addContact = new Contact();
            Console.WriteLine("Enter First Name : ");
            addContact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            addContact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            addContact.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            addContact.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            addContact.Address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            addContact.State = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            addContact.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            addContact.ZipCode = Console.ReadLine();
            addressBookList.Add(addContact);
            Console.WriteLine("Contact Added Successfully!");
        }
        public void DisplayContact()
        {
            Console.WriteLine("Contact Details");
            foreach (Contact display in addressBookList)
            {
                Console.WriteLine(display.FirstName);
                Console.WriteLine(display.LastName);
                Console.WriteLine(display.Email);
                Console.WriteLine(display.PhoneNo);
                Console.WriteLine(display.Address);
                Console.WriteLine(display.State);
                Console.WriteLine(display.City);
                Console.WriteLine(display.ZipCode);
            }
        }
    }
}


