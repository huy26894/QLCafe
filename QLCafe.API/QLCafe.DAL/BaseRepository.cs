using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QLCafe.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
