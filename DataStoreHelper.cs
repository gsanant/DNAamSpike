using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TestDapper
{
    public static class DataStoreHelper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
