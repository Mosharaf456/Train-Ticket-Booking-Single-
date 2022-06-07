using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Train.DatabaseConnection
{
   public class DBConnection
    {
       const  string ConnectiosnString = "Data Source=DESKTOP-59OPBA1;Initial Catalog=Train;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectiosnString);
        public SqlCommand GetCommand(String query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            con.Close();
            return cmd;
        }
        public static SqlConnection ConnectionTest()
        {
            SqlConnection con = new SqlConnection(ConnectiosnString);
            return con;
        }
        public SqlDataAdapter DataAccess(String query)
        {
            SqlDataAdapter sda=new SqlDataAdapter(query, con);

            return sda;
        }
    }
}
