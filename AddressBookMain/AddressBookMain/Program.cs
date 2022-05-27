using AddressBookMain;
internal class Program
{
    public static List<Contacts> person = new List<Contacts>();

    public static void Main(String[] args)
    {
        Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Add Multiple Address Books\n7.Exit\n");
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        AddressBookMain.MyPerson p = new AddressBookMain.MyPerson();
        while (choice != 7)
        {
            Console.Clear();

            switch (choice)
            {
                case 1:
                    AddressBookMain.MyPerson.createContacts();
                    break;
                case 2:
                    //AddressBook.MyPerson.editContacts();
                    break;
                case 3:
                    //AddressBook.MyPerson.removeContact();
                    break;
                case 4:
                    p.displayContacts();
                    break;
                case 5:
                    //p.addMultiContacts();
                    break;
                case 6:
                    //p.addMultiAddressBooks();
                    break;
                default:
                    Console.Write("Enter valid option.\n");
                    break;
            }
            Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Add Multiple Address Books\n7.Exit\n");
            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}

