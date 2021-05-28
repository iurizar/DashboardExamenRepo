using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestorDAL
{
    class ConnectionManager
    {
        private const string LOGIN = @"Data Source=localhost;Initial Catalog=Northwind;User ID=iurizar;Password=pg1234";

        public SqlConnection ConectaBBDD()
        {
            SqlConnection conn = new SqlConnection(LOGIN);
            return conn;
        }
    }
}
