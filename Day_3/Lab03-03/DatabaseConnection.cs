using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab03_03
{
    public class DatabaseConnection
    {
        private readonly string DATA_CONNECTION = "";
        
        public DatabaseConnection()
        {
            DATA_CONNECTION = @"Data Source=LAPTOP-52BB4OF4\HUYNGUYEN ; Initial Catalog = Lab03_03;Integrated Security=true;"; ;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(DATA_CONNECTION);
        }
    }
}
