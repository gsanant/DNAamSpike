using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TestDapper
{
    public class DataAccess
    {
        public List<Customer> FetchCustomers(string partName)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(DataStoreHelper.CnnVal("testDB"))
            {
                connection.Query<Customer>("select * from Customers where ")
            };
            throw new NotImplementedException();
        }
    }
}
