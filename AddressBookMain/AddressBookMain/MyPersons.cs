using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class MyPerson
    {
        public Dictionary<string, List<Contacts>> group = new Dictionary<string, List<Contacts>>();

        public static void createContacts()
        {
            Contacts contact = new Contacts();
            Console.WriteLine("Enter First Name: ");
            contact.fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contact.lName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter State: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            contact.email = Console.ReadLine();

            Program.person.Add(contact);
        }
    }
}