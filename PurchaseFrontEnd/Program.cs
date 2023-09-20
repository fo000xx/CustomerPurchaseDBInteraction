using System;
using System.Runtime.CompilerServices;
using PurchasingEntriesLib;
using PurchasingEntriesTest;

namespace ConsoleTesting
{
    class UIClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following details of the customer");
            Console.Write("First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.WriteLine("Please enter the following details of the purchase");
            Console.Write("Item: ");
            string Item = Console.ReadLine();
            Console.Write("Cost: ");
            string Cost = Console.ReadLine();
        }
    }
}
