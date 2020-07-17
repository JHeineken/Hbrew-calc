using BeerCalculatorClassLibrary.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BeerCalculatorClassLibrary
{
    public class SqliteDataAccess
    {

        public static  List<MaltExtract> LoadExtracts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "select * from Extract";
                var output = cnn.Query<MaltExtract>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
