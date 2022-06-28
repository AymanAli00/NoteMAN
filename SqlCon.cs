using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NoteMAN
{
    public class SqlCon
    {
        public SqlCon()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=ay9s1w0d;Initial Catalog=taskman_db;Integrated Security=True");

        }
    }
}
