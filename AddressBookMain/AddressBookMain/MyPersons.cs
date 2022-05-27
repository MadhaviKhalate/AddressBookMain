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

        public void displayContacts()
        {
            if (Program.person.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }

            Console.WriteLine("1.Total Contacts\n2.Group");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("List of contacts:\n");
                    foreach (var contact in Program.person)
                    {
                        Console.WriteLine("\nFirst Name: " + contact.fName + "\nLast Name: " + contact.lName + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZip Code: " + contact.zip + "\nContact No.: " + contact.phoneNo + "\nEmail address: " + contact.email + "----------------------------------------------\n");
                    }
                    break;
                case 2:
                    foreach (string key in group.Keys)
                    {
                        Console.WriteLine(key);
                    }

                    Console.WriteLine("Enter group you want to display.");
                    string gName = Console.ReadLine();
                    List<Contacts> list = group[gName];

                    foreach (var contact in list)
                        Console.WriteLine("\nFirst Name: " + contact.fName + "\nLast Name: " + contact.lName + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZip Code: " + contact.zip + "\nContact No.: " + contact.phoneNo + "\nEmail address: " + contact.email + "----------------------------------------------\n");
                    break;
            }

        }
    }
}