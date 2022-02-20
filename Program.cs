// See https://aka.ms/new-console-template for more information
using System;
namespace Address_Book
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Address Book Program");

            Console.WriteLine("Enter how many contacts you want to store");
            int number = Convert.ToInt32(Console.ReadLine());
            AddressBook book = new AddressBook();

            for (int i = 1; i <= number; i++)
            {

                Contacts contacts = new Contacts();

                Console.WriteLine("\nEnter Name");
                contacts.name = Console.ReadLine();

                Console.WriteLine("Enter address");
                contacts.address = Console.ReadLine();

                Console.WriteLine("Enter city");
                contacts.city = Console.ReadLine();

                Console.WriteLine("Enter state");
                contacts.state = Console.ReadLine();

                Console.WriteLine("Enter zip");
                contacts.zip = Console.ReadLine();

                Console.WriteLine("Enter Phone number");
                contacts.phoneNo = Console.ReadLine();

                Console.WriteLine("Enter Phone email");
                contacts.email = Console.ReadLine();

                book.AddContact(contacts.name, contacts.address, contacts.city, contacts.state, contacts.zip, contacts.phoneNo, contacts.email);
            }
            Console.WriteLine("\nIf you want to edit contact plz enter name");
            string name =Console.ReadLine();
            book.Edit(name);







        }
    }
}
