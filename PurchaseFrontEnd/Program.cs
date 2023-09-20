using System;
using System.Runtime.CompilerServices;
using PurchasingEntriesLib;

namespace ConsoleTesting
{
    class UIClass
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following details of the customer");

            var customer = new AddCustomer();
            Console.Write("First Name: ");
            customer.GetFirstName();
            Console.Write("Last Name: ");
            customer.GetLastName();
            Console.Write("Email: ");
            customer.GetEmail();

            Console.WriteLine("Please enter the following details of the purchase");
            
            var purchase = new AddPurchase();
            Console.Write("Item: ");
            purchase.GetItemName();
            Console.Write("Cost: ");
            purchase.GetCost();

            Console.WriteLine(/*Details that have just been entered for confirmation*/);
            Console.WriteLine("Your entry has been received. Thank You.");
        }
    }
}
