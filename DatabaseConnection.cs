using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class DatabaseConnection
    {
        public string ConnectionString = "Server = LAPTOP-ASVD7906 ; Database=lemonadestand; Integrated Security=true;";
        SqlConnection con;

       
        public DatabaseConnection()
        {
            con = new SqlConnection(ConnectionString);
        }


       
        public void OpenConnection()
        {
            
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
    }

}
