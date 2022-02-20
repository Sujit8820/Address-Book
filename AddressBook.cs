using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{

    class AddressBook
    {

        List<Contacts> contacts = new List<Contacts>();

        public void AddContact(string name, string address, string city, string state, string zip, string phoneNo, string email)
        {

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

        public void Edit(string name)
        {
            Contacts editContact = null;
            foreach (var contact in contacts)
            {
                if (contact.name == name)
                {
                    editContact = contact;
                }
            }
            Console.WriteLine("Enter 1,2,3,4,5,6 & 7 for edit name,address,city,state,zip,Phone number & email respectively");
            int edit = Convert.ToInt32(Console.ReadLine());

            switch (edit)
            {
                case 1:
                    Console.WriteLine("Enter new name");
                    editContact.name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter new address");
                    editContact.address = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new city");
                    editContact.city = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter new state");
                    editContact.state = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter new zip");
                    editContact.zip = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Enter new phone number");
                    editContact.phoneNo = Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Enter new email");
                    editContact.email = Console.ReadLine();
                    break;
            }
            contacts.Add(editContact);
            Console.WriteLine($"{name} contact eidted");

        }
        public void Remove(string name)
        {
            Contacts RemoveContact = null;
            foreach (var contact in contacts)
            {
                if (contact.name == name)
                {
                    RemoveContact = contact;
                }
            }
            contacts.Remove(RemoveContact);
            Console.WriteLine($"{name} contact removed");
        }
    }
}
