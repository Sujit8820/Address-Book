using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Input
    {
        public AddressBook book = new AddressBook();
        Contacts contacts = new Contacts();
        Dictionary<string, AddressBook> AddressBooks = new Dictionary<string, AddressBook>();

        public void TakeInput(int number, string bookName)
        {
            for (int i = 1; i <= number; i++)
            {


                Console.Write("\nEnter Name: ");
                contacts.name = Console.ReadLine();

                Console.Write("Enter address: ");
                contacts.address = Console.ReadLine();

                Console.Write("Enter city: ");
                contacts.city = Console.ReadLine();

                Console.Write("Enter state: ");
                contacts.state = Console.ReadLine();

                Console.Write("Enter zip: ");
                contacts.zip = Console.ReadLine();

                Console.Write("Enter Phone number: ");
                contacts.phoneNo = Console.ReadLine();

                Console.Write("Enter Phone email: ");
                contacts.email = Console.ReadLine();


                book.AddContact(contacts.name, contacts.address, contacts.city, contacts.state, contacts.zip, contacts.phoneNo, contacts.email);
                AddressBooks.Add(bookName + i, book);
                if (number > 1 && i < number)
                {
                    Console.WriteLine("\n Add next details");
                }


            }

            Console.Write("\nEnter 1 for edit contact, 2 for remove contact & 3 for nothing: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("\nIf you want to edit contact plz enter name: ");
                    string name = Console.ReadLine();
                    book.Edit(name);
                    break;
                case 2:
                    Console.Write("\nIf you want to remove contact plz enter name: ");
                    string Name = Console.ReadLine();
                    book.Remove(Name);
                    break;
                default:
                    Console.WriteLine("Ok");
                    break;

            }
        }
    }
}
