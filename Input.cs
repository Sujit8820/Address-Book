using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Input
    {
        Collection book = new Collection();

        public void TakeInput(int number)
        {
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

                if (number > 1 && i < number)
                {
                    Console.WriteLine("\n Add next details");
                }


            }

            Console.WriteLine("\nEnter 1 for edit contact, 2 for remove contact & 3 for nothing");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nIf you want to edit contact plz enter name");
                    string name = Console.ReadLine();
                    book.Edit(name);
                    break;
                case 2:
                    Console.WriteLine("\nIf you want to remove contact plz enter name");
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
