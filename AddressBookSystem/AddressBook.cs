using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void EditContact(string firstName, string lastName)
        {
            foreach (var contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    Console.WriteLine("Enter New Address:");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter New City:");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter New State:");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter New Zip:");
                    string zip = Console.ReadLine();

                    Console.WriteLine("Enter New Phone Number:");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter New Email:");
                    string email = Console.ReadLine();

                    contact.Address = address;
                    contact.City = city;
                    contact.State = state;
                    contact.Zip = zip;
                    contact.PhoneNumber = phoneNumber;
                    contact.Email = email;

                    Console.WriteLine("Contact Updated Successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found!");
        }

        public void DisplayContacts()
        {
            Console.WriteLine("Address Book Contacts:");
            foreach (var contact in contacts)
            {
                contact.DisplayContactInfo();
                Console.WriteLine();
            }
        }

    }
}
