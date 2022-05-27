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

        public static void editContacts()
        {
            Console.WriteLine("Enter Name of person to edit details: ");
            string name = Console.ReadLine();

            foreach (var contact in Program.person)
            {
                if (contact.fName.Equals(name))
                {
                    Console.WriteLine("Which field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone No.\n8.Email");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name to update:");
                            contact.fName = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name to update:");
                            contact.lName = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to update:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter City to update:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter State to update:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip code to update:");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone to update:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter Email to update:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Invalid option:");
                            break;
                    }
                }
            }
        }
        public static void removeContact()
        {
            Console.WriteLine("Enter Name of person to delete details: ");
            string name = Console.ReadLine();

            foreach (var contact in Program.person.ToList())
            {
                if (contact.fName.Equals(name))
                {
                    Program.person.Remove(contact);
                }
            }
        }
        public void addMultiContacts()
        {
            Console.WriteLine("How many contacts you want to add:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createContacts();
                n--;
            }
        }
    }
}