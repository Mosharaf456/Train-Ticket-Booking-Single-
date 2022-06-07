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
using Train.Entities;
using Train.DatabaseConnection;


namespace Train
{
    public partial class RegisterNewAccount : Form
    {
        DBConnection dbc = new DBConnection();
        SqlConnection con = DBConnection.ConnectionTest();
        //3 // const string connectionString = "Data Source=DESKTOP-U5U2H6N;Initial Catalog=Train;Integrated Security=True";
        // 4// SqlConnection con = new SqlConnection(connectionString);
        public RegisterNewAccount()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
        public void RMethod(string s)
        {
            this.lbltitle.Text = s;
        }
        string gnd;
        string status = "User";
        //Regiter new account
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (textUN.Text == "" || textPD.Text == "" || textCP.Text == "" || txtE.Text == "" || dateTimePicker1.CustomFormat == " " || rdbtnmale.Checked == false && rdbtnfemale.Checked == false)
            {
                MessageBox.Show("Please fill up all property!!");
            }
            else
            {
             
                String st = "INSERT INTO users(username,email,password,dob,gender,Status)" +
                    "VALUES('" + textUN.Text + "','" + txtE.Text + "','" + textPD.Text + "','" + dateTimePicker1.Text + "','" + gnd + "','" + status + "')";
                //DBConnection dbc=new DBConnection();
                SqlCommand cmd = new SqlCommand(st, con);
               // SqlCommand cmd = dbc.GetCommand(st);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        User user = new User(new String[] { textUN.Text, txtE.Text, textPD.Text, dateTimePicker1.Text, gnd, textCP.Text, status });
                        int val = cmd.ExecuteNonQuery();
                        MessageBox.Show("Connection made successfully\nNumber of affected rows:" + val);
                        dateTimePicker1.CustomFormat = " ";
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Insert rows Failed");
                }
            }

        }
    private void rdbtnmale_CheckedChanged(object sender, EventArgs e)
    {
        this.gnd = "Male";
    }

    private void rdbtnfemale_CheckedChanged(object sender, EventArgs e)
    {
        gnd = "Female";
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Back)||(e.KeyCode==Keys.Delete))
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textUN.Text = "";
            textPD.Text = "";
            textCP.Text = "";
            txtE.Text = "";
            dateTimePicker1.CustomFormat = " ";
            rdbtnmale.Checked =false;
            rdbtnfemale.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
