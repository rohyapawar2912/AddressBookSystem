using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();

            Console.WriteLine();
            contact.DisplayContactInfo();
        }
    }
}
