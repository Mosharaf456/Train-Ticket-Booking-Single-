using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainUI.DataAccess
{
    class SqlDbDataAccess
    {
        const string ConnectiosnString = "Data Source=DESKTOP-U5U2H6N;Initial Catalog=Train;Integrated Security=True";
        public SqlCommand GetCommand(String query)
        {
            var connection = new SqlConnection(ConnectiosnString);

            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
