using System.Data.SqlClient;

namespace DB__PROJECT
{
    public static class DB
    {
        //DB connection 
        public static SqlConnection con =
            new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
    }
}