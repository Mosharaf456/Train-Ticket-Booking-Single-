using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Train.DatabaseConnection;

namespace Train
{
    //Delegate
    public delegate void RegDelegate(string s);
    public partial class LoginForm : Form
    {
        DBConnection dbc = new DBConnection();
        SqlConnection con = DBConnection.ConnectionTest();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Fill up all property!");
            }
            else
            {
                String query = "select Status,id from users where username='" + txtuserName.Text + "' and password='" + txtpassword.Text + "'";
                try
                {
                    SqlDataAdapter sda = dbc.DataAccess(query);
                    DataTable dt = new DataTable();//4
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        TicketBooking tb = new TicketBooking(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                      //  MessageBox.Show("You Log in as " + dt.Rows[0][0].ToString());
                        tb.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username and Password or You can Register for new account");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
    
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnregister_Click(object sender, EventArgs e)
        {
            RegisterNewAccount rna = new RegisterNewAccount();
            //Method binding
            //  RegDelegate rd = new RegDelegate(rna.RMethod);
            RegDelegate rd = rna.RMethod;
            rd("Create a new user Account");
            this.Hide();
            rna.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtuserName.Text = "";
            txtpassword.Text = "";
        }
    }
}
