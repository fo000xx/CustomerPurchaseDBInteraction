using PurchasingEntriesLib.Models;
using System.Data;

namespace PurchasingEntriesLib.Data
{
    public interface ICustomerData
    {
        ParameterDirection? Output { get; }

        Task InsertPurchase(CustomerPurchase CustomerPurchaseData);
    }
}