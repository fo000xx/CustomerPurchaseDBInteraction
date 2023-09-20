namespace PurchasingEntriesLib
{
    public class AddCustomer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string EmailAddress { get; set; }
        
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
    }
}
