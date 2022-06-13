using AddressBookMain;
internal class Program
{
    public static List<Contacts> person = new List<Contacts>();

    public static void Main(String[] args)
    {
        Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts" +
            "\n5.Add Multiple Contacts\n6.Add Multiple Address Books\n7.Search City or State" +
            "\n8.To Dictionary for City and State\n9.Read Write Operation on File\n10.Read Write Operation on .CSV File");
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        MyPerson p = new MyPerson();
            switch (choice)
            {
                case 1:
                    p.createContacts();
                    p.displayContacts();
                    break;
                case 2:
                    p.createContacts();
                    p.editContacts();
                    p.displayContacts();
                    break;
                case 3:
                    p.addMultiContacts();
                    p.removeContact();
                    p.displayContacts();
                    break;
                case 4:
                    p.displayContacts();
                    break;
                case 5:
                    p.addMultiContacts();
                    break;
                case 6:
                    p.addMultiAddressBooks();
                    break;
                case 7:
                    p.searchForCityOrState();
                    break;
                case 8:
                    p.CityAndStateInDictionary();
                break;
                case 9:
                    p.WriteInTextFile();
                    p.ReadFromTextFile();
                break;
                case 10:
                    p.WriteIntoCSVFile();
                    p.ReadFromCSVFile();
                break;
            default:
                    Console.Write("Enter valid option.\n");
                    break;
            }
    }
}

