using Dapper;
using PurchasingEntriesLib.Models;
using System.Data;

namespace PurchasingEntriesLib.Data;

public class CustomerData : ICustomerData
{
    public ISqlDataAccess _sql;
    public CustomerData(ISqlDataAccess sql)
    {
        _sql = sql;
    }

    public ParameterDirection? Output { get; private set; }

    public async Task InsertPurchase(CustomerPurchase CustomerPurchaseData)
    {
        DynamicParameters parameter = new();
        parameter.Add("@CustomerId", dbType: System.Data.DbType.Int32, direction: Output);
        parameter.Add("@szFirstName", CustomerPurchaseData.FirstName);
        parameter.Add("@szLastName", CustomerPurchaseData.LastName);
        parameter.Add("@szEmail", CustomerPurchaseData.EmailAddress);

        await _sql.SaveData("dbo.spCustomerUpsert", parameter);

        int customerId = parameter.Get<int>("@CustomerId");

        parameter = new();
        parameter.Add("@Item", CustomerPurchaseData.ItemName);
        parameter.Add("@Cost", CustomerPurchaseData.Cost);
        parameter.Add("@CustomerId", customerId);

        await _sql.SaveData("dbo.spPurchase_Insert", parameter);
    }

}
