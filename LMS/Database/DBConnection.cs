using System.Data.SqlClient;

namespace LMS
{
    public class DBConnection
    {
        public static string connectionString =
            @"Data Source=LAPTOP-7VKDU2HH\SQLEXPRESS;Initial Catalog=LibraryManagementDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}