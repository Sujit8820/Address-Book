using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Input
    {
        public void input()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone number");
            string phoneNO = Console.ReadLine();

            Console.WriteLine("Enter Phone email");
            string email = Console.ReadLine();


            AddressBook.AddContact(name, address, city, state, zip, phoneNO, email);
        }
    }
    class AddressBook 
    {

  
        public static void AddContact(string name, string address, string city, string state, string zip, string phoneNo,string email)
        {
            List<Contacts> contacts = new List<Contacts>();

            contacts.Add(new Contacts()
            {
                name = name,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phoneNo = phoneNo,
                email = email
            });
            Console.WriteLine($"Contact of {name} is added");

        }
    }
}
