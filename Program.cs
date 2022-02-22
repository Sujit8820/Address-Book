// See https://aka.ms/new-console-template for more information
using System;
namespace Address_Book
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Address Book Program\n");
            Console.WriteLine("Enter how many contacts you want to store");
            int number = Convert.ToInt32(Console.ReadLine());
            Input input = new Input();
            input.TakeInput(number);

        }
    }
}
