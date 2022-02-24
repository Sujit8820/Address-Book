// See https://aka.ms/new-console-template for more information
using System;
namespace Address_Book
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Address Book Program\n");


            Console.Write("Enter how many address books you want to add: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Input input = new Input();



            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();
                Console.Write("How many contacts you wanted to add: ");
                int ContactNumbers = Convert.ToInt32(Console.ReadLine());
                Contacts contacts = null;
                input.TakeInput(ContactNumbers, bookName);


            }

        }

    }
}








