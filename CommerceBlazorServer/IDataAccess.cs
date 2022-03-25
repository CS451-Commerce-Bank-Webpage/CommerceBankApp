using System.Collections.Generic;

namespace DataLibrary
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sql, U parameters, string connectionString);
        void SaveData<T, U>(string sql, U parameters, string connectionString);
    }
}