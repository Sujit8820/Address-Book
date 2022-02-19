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
       
        public void AddContact(string name, string address, string city, string state, string zip, string phoneNo,string email)
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
    }
}
