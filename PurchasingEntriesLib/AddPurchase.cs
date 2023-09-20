namespace PurchasingEntriesLib
{
    public class AddPurchase
    {
        private string ItemName { get; set; }
        private string Cost { get; set; }

        public void GetItemName()
        {
            ItemName = Console.ReadLine();
        }

        public void GetCost()
        {
            Cost =  Console.ReadLine();
        }

    }
}