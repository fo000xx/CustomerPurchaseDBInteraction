using Dapper;

namespace PurchasingEntriesLib.Data
{
    public interface ISqlDataAccess
    {
        Task SaveData(string storedProcedure, DynamicParameters data, string connectionStringName = "Default");
    }
}