using PurchasingEntriesLib.Models;

namespace ConsoleTesting
{
    class UIClass
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following details of the customer");

            var customer = new CustomerPurchase();
            Console.Write("First Name: ");
            customer.GetFirstName();
            Console.Write("Last Name: ");
            customer.GetLastName();
            Console.Write("Email: ");
            customer.GetEmail();

            Console.WriteLine("Please enter the following details of the purchase");

            Console.Write("Item: ");
            customer.GetItemName();
            Console.Write("Cost: ");
            customer.GetCost();

            Console.WriteLine(/*Details that have just been entered for confirmation*/);
            Console.WriteLine("Your entry has been received. Thank You.");
        }
    }
}
