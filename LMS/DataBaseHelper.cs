using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public static class DataBaseHelper
    {
        //Server
        public static readonly string ConnectionString = @"Data Source=LAPTOP-7VKDU2HH\SQLEXPRESS;Initial Catalog=LibraryManagementDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
