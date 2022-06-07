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
    public partial class Information : Form
    {
        DBConnection dbc = new DBConnection();
        SqlConnection con = DBConnection.ConnectionTest();
        public Information(string s,string p)
        {
            InitializeComponent();
            lblstatus.Text = s;
            infmlblid.Text = p;
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketBooking(lblstatus.Text, infmlblid.Text).Show();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainDataSet3.trainschedule' table. You can move, or remove it, as needed.
            this.trainscheduleTableAdapter2.Fill(this.trainDataSet3.trainschedule);
            // TODO: This line of code loads data into the 'trainDataSet.trainschedule' table. You can move, or remove it, as needed.
            this.trainscheduleTableAdapter1.Fill(this.trainDataSet.trainschedule);
            // TODO: This line of code loads data into the 'trainDataSet2.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.trainDataSet2.users);
            // TODO: This line of code loads data into the 'trainDataSet2.trainschedule' table. You can move, or remove it, as needed.
            this.trainscheduleTableAdapter.Fill(this.trainDataSet2.trainschedule);

        }

        private void btntrainlist_Click(object sender, EventArgs e)
        {
            if (lblstatus.Text == "User")
            {
               // MessageBox.Show("USER ACCOUNT");
                btnuserList.Enabled = false;


                String query = "select * from trainschedule";

                SqlDataAdapter sda = dbc.DataAccess(query);
                DataTable dt = new DataTable();//4
                sda.Fill(dt);
                dgvtrainlist.DataSource = dt;
                //Dynamic Button creation give notice for user
                Button b = new Button();
                b.Text = "Click Me";
                b.Size = new Size(70, 30);
                b.Location = new Point(140, 18);
                this.Controls.Add(b);
                b.Click += new System.EventHandler(b_Click);
                b.Click += delegate (object s, EventArgs ea)
                {
                    MessageBox.Show("Those buttons are only for admin member");
                };
               // MessageBox.Show("Test");

            }
            if (lblstatus.Text == "Admin")
            {
              //  MessageBox.Show("Admin account");
                btnuserList.Enabled = true;


                String query = "select * from trainschedule";

                SqlDataAdapter sda = dbc.DataAccess(query);
                DataTable dt = new DataTable();//4
                sda.Fill(dt);
                dgvtrainlist.DataSource = dt;


            }
  
        }
       //Dynamic button Event handler for user notice
        private void b_Click(Object s, EventArgs e)
        {
            MessageBox.Show("AS you are a user so some buttons are enabled false");
        }

        private void btnuserList_Click(object sender, EventArgs e)
        {
            if (lblstatus.Text == "Admin")
            {
              //  MessageBox.Show("Admin account");
                btnuserList.Enabled = true;
                btntrainlist.Enabled = true;


                String query = "select id,username,email,dob,gender from users ";

                SqlDataAdapter sda = dbc.DataAccess(query);
                DataTable dt = new DataTable();//4
                sda.Fill(dt);
                dgvuserlist.DataSource = dt;


            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
