using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    public class MyPerson
    {
        List<Contacts> group = new List<Contacts>();
        Dictionary<string, List<Contacts>> book = new Dictionary<string, List<Contacts>>();

        Contacts contact;
        public void createContacts()
        {
            contact = new Contacts();
            bool status = true;
            while (status)
            {
                Console.Write("Enter First Name: ");
                contact.fName = Console.ReadLine();
                if (group.Any(e => e.fName.Equals(contact.fName)))
                {
                    Console.WriteLine("Name already exist in Address Book. Please Enter a New Name");
                }
                else
                {
                    status = false;
                }
            }
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

            group.Add(contact);
        }

        public void displayContacts()
        {
            foreach (var details in group)
            {
                Console.WriteLine("First Name: " + details.fName + "\nLast Name: " + details.lName + "\nAddress: "
                + details.address + "\nCity: " + details.city + "\nCity: " + details.city + "\nZip Code: "
                + details.zip + "\nPhone Number: " + details.phoneNo + "\nEmail: " + details.email + "\n");
            }
            if (group.Count == 0)
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

        public void editContacts()
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
        public void removeContact()
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
        public void addMultiAddressBooks()
        {
            Console.WriteLine("Enter the number of book you want to add: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput > 0)
            {
                Console.WriteLine("Enter Group Name: ");
                string groupName = Console.ReadLine();
                addMultiContacts();
                book.Add(groupName, group);
                userInput--;
            }

            foreach (var bookName in book)
            {
                Console.WriteLine("Grouping Name is :" + bookName.Key + "\n");
                foreach (var list in bookName.Value)
                {
                    Console.WriteLine("First Name: " + list.fName + "\nLast Name: " + list.lName + "\nAddress: "
                 + list.address + "\nCity: " + list.city + "\nCity: " + list.city + "\nZip Code: "
                 + list.zip + "\nPhone Number: " + list.phoneNo + "\nEmail: " + list.email + "\n");
                }
            }
        }
        public void searchForCityOrState()
        {
            addMultiAddressBooks();           
            Console.WriteLine("1.Search contacts by city\n2.Search contacts by State");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter a City Name to be Search: ");
                        string searchCity = Console.ReadLine();
                        foreach (var bookName in book)
                        {
                            Console.WriteLine("Group Name is :" + bookName.Key + "\n");
                            foreach (var list in bookName.Value.FindAll(e => (e.city.Equals(searchCity))).ToList())
                            {
                                Console.WriteLine("First Name: " + list.fName + "\nLast Name: " + list.lName + "\nAddress: "
                                + list.address + "\nCity: " + list.city + "\nState: " + list.state + "\nZip Code: "
                                + list.zip + "\nPhone Number: " + list.phoneNo + "\nEmail: " + list.email + "\n");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter a State Name to be Search: ");
                        string searchState = Console.ReadLine();
                        foreach (var bookName in book)
                        {
                            Console.WriteLine("Group Name is :" + bookName.Key + "\n");
                            foreach (var list in bookName.Value.FindAll(e => e.state.Equals(searchState)).ToList())
                            {
                                Console.WriteLine("First Name: " + list.fName + "\nLast Name: " + list.lName + "\nAddress: "
                                + list.address + "\nCity: " + list.city + "\nState: " + list.state + "\nZip Code: "
                                + list.zip + "\nPhone Number: " + list.phoneNo + "\nEmail: " + list.email + "\n");
                            }
                        }
                        break;
                    }
            }
        }
        public void CityAndStateInDictionary()
        {
            List<Contacts> city = new List<Contacts>();
            List<Contacts> state = new List<Contacts>();
            Dictionary<string, List<Contacts>> cityDictionary = new Dictionary<string, List<Contacts>>();
            Dictionary<string, List<Contacts>> stateDictionary = new Dictionary<string, List<Contacts>>();
            int countCity = 0, countState = 0;
            addMultiAddressBooks();
            Console.WriteLine("Enter a City Name to create key in dictionary: ");
            string searchCity = Console.ReadLine();
            foreach (var bookName in book)
            {
                foreach (var list in bookName.Value.FindAll(e => (e.city.Equals(searchCity))))
                {
                    if (list.city.Equals(searchCity))
                    {
                        city.Add(list);
                        countCity++;
                    }
                }
            }
            cityDictionary.Add(searchCity, city);

            Console.WriteLine("Enter a State Name to create key in dictionary: ");
            string searchState = Console.ReadLine();
            foreach (var bookName in book)
            {
                foreach (var list in bookName.Value.FindAll(e => (e.state.Equals(searchState))))
                {
                    if (list.state.Equals(searchState))
                    {
                        state.Add(list);
                        countState++;
                    }
                }
            }
            stateDictionary.Add(searchState, state);
          
            Console.WriteLine("\nContacts in " + searchCity);
            foreach (var City in cityDictionary)
            {
                foreach (var data in City.Value)
                {
                    Console.WriteLine("First Name: " + data.fName + "\nCity: " + data.city);
                }
            }
            Console.WriteLine("Number of Contacts in " + searchCity + ": " + countCity);

            Console.WriteLine("\nContacts in " + searchState);
            foreach (var State in stateDictionary)
            {
                foreach (var data in State.Value)
                {
                    Console.WriteLine("First Name: " + data.fName + "\nState: " + data.state);
                }
            }
            Console.WriteLine("Number of Contacts in " + searchState + ": " + countState);
        }
    }
}