using System;
using System.Data.SqlClient;
using System.Net.Security;

namespace PurchasingEntriesLib.Models
{
    public class CustomerPurchase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ItemName { get; set; }
        public string Cost { get; set; }

        public void GetFirstName()
        {
            FirstName = Console.ReadLine();
        }
        public void GetLastName()
        {
            LastName = Console.ReadLine();
        }
        public void GetEmail()
        {
            EmailAddress = Console.ReadLine();
        }
        public void GetItemName()
        {
            ItemName = Console.ReadLine();
        }

        public void GetCost()
        {
            Cost = Console.ReadLine();
        }

    }
}
