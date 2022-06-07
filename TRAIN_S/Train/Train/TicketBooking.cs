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
using TrainUI.Entities;
using Train.DatabaseConnection;

namespace Train
{
    public partial class TicketBooking : Form
    {
        DBConnection dbc = new DBConnection();
        SqlConnection con = DBConnection.ConnectionTest();
        public string loginId;
        public TicketBooking(String status, String id)
        {
            InitializeComponent();
            lblstatus.Text = status;
            //
            lbltbID.Text = id;
            this.loginId = id;
            if (lblstatus.Text == "User")
            {
                btnaddUser.Enabled = false;
                btnuserList.Enabled = false;
                btndeleteUser.Enabled = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void TicketBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainDataSet5.trainschedule' table. You can move, or remove it, as needed.
            this.trainscheduleTableAdapter2.Fill(this.trainDataSet5.trainschedule);
            // TODO: This line of code loads data into the 'trainDataSet4.trainschedule' table. You can move, or remove it, as needed.
            this.trainscheduleTableAdapter1.Fill(this.trainDataSet4.trainschedule);
            // TODO: This line of code loads data into the 'trainDataSet.trainschedule' table. You can move, or remove it, as needed.
            //this.trainscheduleTableAdapter.Fill(this.trainDataSet.trainschedule);
            // TicketBooking.Add(pnleditUser);
            //   listPanel.Add(pnleditUser);
            // listPanel[index].BringToFront();
            pdesComboboxTQ.Text = "Select";
            pdescombobox.Text = "...Select...";

            PanelVisibleFalse();
        }
        public void PanelVisibleFalse()
        {
            pnleditUser.Visible = false;
            padduser.Visible = false;
            pdelete.Visible = false;
            //
            pnldestination.Visible = false;
        }
        private void btneditUser_Click(object sender, EventArgs e)
        {
            PanelVisibleFalse();

            if (padduser.Visible == true || pdelete.Visible == true || pnldestination.Visible == true)
            {
                padduser.Visible = false;
                pdelete.Visible = false;
                pnldestination.Visible = false;
            }
            else
            {
                pnleditUser.Visible = true;
                pnleditUser.BringToFront();
            }

        }

        string email = "";
        int i = 0;

        private void pbtnsearch_Click(object sender, EventArgs e)

        {
            if (ptxtsearchEmail.Text == "")
            {
                MessageBox.Show("Type your email");
            }
            else
            {
                String query = "SELECT [username],[email],[password],[dob],[gender] FROM[dbo].[users] where email ='" + ptxtsearchEmail.Text + "'";
                try
                {


                    SqlDataAdapter sda = dbc.DataAccess(query);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    { ///
                        email = ptxtsearchEmail.Text;
                        MessageBox.Show("Test2" + email);
                        ptxtuserName.Text = dt.Rows[0][0].ToString();
                        ptxtemail.Text = dt.Rows[0][1].ToString();
                        ptxtpassword.Text = dt.Rows[0][2].ToString();
                        ptxtdob.Text = dt.Rows[0][3].ToString();
                        if (String.Format("{0}", dt.Rows[0][4]) == "Male" || String.Format("{0}", dt.Rows[0][4]) == "male")
                        {
                            prbtnmale.Checked = true;
                            prbtnfemale.Checked = false;

                        }
                        else
                        {
                            prbtnfemale.Checked = true;
                            prbtnmale.Checked = false;
                        }
                        i++;
                    }

                    else
                    {
                        MessageBox.Show("Incorrect Email");
                    }


                }
                catch (SqlException ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string gender;
        private void prbtnmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void prbtnfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void btnaddUser_Click(object sender, EventArgs e) ///wprking
        {
            PanelVisibleFalse();
            if (pnleditUser.Visible == true || pdelete.Visible == true || pnldestination.Visible == true)
            {
                pnleditUser.Visible = false;
                pdelete.Visible = false;
                pnldestination.Visible = false;
            }
            else
            {
                padduser.Visible = true;
                padduser.BringToFront();
            }



        }

        /////UserList
        private void btnuserList_Click(object sender, EventArgs e)
        {

            PanelVisibleFalse();
            this.Hide();
            new Information(lblstatus.Text, lbltbID.Text).Show();

        }

        private void btndeleteUser_Click(object sender, EventArgs e)
        {

            PanelVisibleFalse();
            if (padduser.Visible == true || pnleditUser.Visible == true || pnldestination.Visible == true)
            {
                padduser.Visible = false;
                pnleditUser.Visible = false;
                pnldestination.Visible = false;

            }
            else
            {
                pdelete.Visible = true;
                pdelete.BringToFront();
            }
        }

        private void pdbtndelete_Click(object sender, EventArgs e)
        {
            if (pdtxtemail.Text == "")
            {
                MessageBox.Show("Please enter email");
            }
            else
            {
                String st = "DELETE FROM [dbo].[users]   WHERE email='" + pdtxtemail.Text + "'";
                SqlCommand cmd = new SqlCommand(st, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int val = cmd.ExecuteNonQuery();
                        MessageBox.Show("Connection made successfully\nNumber of affected rows:" + val);
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Delete rows Failed");
                    con.Close();
                }
                pdtxtemail.Text = "";

            }

        }
        string gnd;
        private void prbtnmaleA_CheckedChanged(object sender, EventArgs e)
        {
            this.gnd = "Male";
        }
        private void prbtnfemaleA_CheckedChanged(object sender, EventArgs e)
        {
            this.gnd = "Female";
        }
        private void pedubtnedit_Click(object sender, EventArgs e)
        {
            if (i == 0 || email == "" || ptxtuserName.Text == "" || ptxtemail.Text == "" || ptxtpassword.Text == "" || ptxtdob.Text == "" || prbtnmale.Checked == false && prbtnfemale.Checked == false)
            {
                MessageBox.Show("search your email on the search button");
            }
            else
            {
                String st = "update users set username='" + ptxtuserName.Text + "',email ='" + ptxtemail.Text + "' ,password ='" + ptxtpassword.Text + "' ,dob ='" + ptxtdob.Text + "',gender ='" + gender + "' where email='" + email + "' ";
                SqlCommand cmd = new SqlCommand(st, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    try
                    {

                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("Connection made successfully\nNumber of affected rows:" + i);
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Update rows Failed");
                    con.Close();
                }
            }
            i = 0;
            email = "";
            ptxtuserName.Text = "";
            ptxtemail.Text ="";
            ptxtpassword.Text = "";
            ptxtdob.Text = "";
            prbtnmale.Checked = false;
            prbtnfemale.Checked = false;
        }
        private void pbtnaddUser_Click_1(object sender, EventArgs e)
        {
            if (ptxtuserNameA.Text == "" || ptxtemailA.Text == "" || ptxtpasswordA.Text == "" || ptxtdobA.Text == "" || prbtnmaleA.Checked == false && prbtnfemaleA.Checked == false)
            {
                MessageBox.Show("Fill up all property!");
            }
            else
            {
                string s = lblstatus.Text;
                String st = "INSERT INTO users(username,email,password,dob,gender,Status)" +
                    "VALUES('" + ptxtuserNameA.Text + "','" + ptxtemailA.Text + "','" + ptxtpasswordA.Text + "','" + ptxtdobA.Text + "','" + gnd + "','" + s + "')";
                //DBConnection dbc=new DBConnection();
                SqlCommand cmd = new SqlCommand(st, con);//2
                // SqlCommand cmd = dbc.GetCommand(st);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int val = cmd.ExecuteNonQuery();
                        MessageBox.Show("ADD rows successfully\nNumber of affected rows:" + val);
                        con.Close();
                        ptxtuserNameA.Text = "";
                        ptxtemailA.Text = "";
                        ptxtpasswordA.Text = "";
                        ptxtdobA.Text = "";
                        prbtnmaleA.Checked = false;
                        prbtnfemaleA.Checked = false;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("ADD rows Failed");
                }
            }

        }
        //Button destination event handler
        private void btndestination_Click(object sender, EventArgs e)
        {
            PanelVisibleFalse();
            ///
            pdescombobox.Text = "";
            pdestxtST.Text = "";
            pdestxtTN.Text = "";
            pdestxtDT.Text = "";
            pdestxtAT.Text = "";
            pdesdTP.Text = "";
            pdesrbtnFC.Checked = false;
            pdesrbtnN.Checked = false;

            if (padduser.Visible == true || pdelete.Visible == true || pnleditUser.Visible == true)
            {
                padduser.Visible = false;
                pdelete.Visible = false;
                pnleditUser.Visible = false;
            }
            else
            {

                pnldestination.Visible = true;
                pnldestination.BringToFront();//
            }
        }

        public static int k = 0;
        int t = 0;
        private void pdesbtnpurchase_Click(object sender, EventArgs e)
        {
            if (pdescombobox.SelectedIndex == -1 || pdesComboboxTQ.SelectedIndex == -1 || pdestxtST.Text == "" || pdestxtTN.Text == "" || pdestxtDT.Text == "" || pdestxtAT.Text == "" || pdesdTP.Text == "" || pdesrbtnFC.Checked == false && pdesrbtnN.Checked == false)
            {
                MessageBox.Show("please selecte destination and Total ticket buy both!");
            }
            else
            {
                //Entity class instence
                TicketInfo tif = new TicketInfo(new string[] { pdestxtST.Text, pdestxtTN.Text, pdestxtDT.Text, pdestxtAT.Text, pdesdTP.Text, ticketType });
                tif.Ticketbuy = pdesComboboxTQ.SelectedIndex + 1;
               //Train ticket capacity counter c
                int c = tif.Capacity(pdesComboboxTQ.SelectedIndex + 1);

                if (c <= 800000000000)
                {
                
                     t = pdesComboboxTQ.SelectedIndex + 1;
                    if (t == 1)
                    {
                        k += t;
                    }
                    else if (t == 2)
                    {
                        k += t;
                    }
                    else if (t == 3)
                    {
                        k += t;
                    }
                    else if (t == 4)
                    {
                
                        k += t;    
                    }
                    // user maximum ticket limitcounter
                    if (k > 4)
                    {
                        MessageBox.Show("Your wanted limit: " + k+" Over then  max limit 4" );
                        // to insert information  Ticket
                       TicketBooking.k -= t;
                        PurchaseDetails(0, "", "", "");
                        MessageBox.Show("Last successful Parchased total Ticket:" + k);
                    }
                    else
                    {
                        pdeslblShowB.Text = tif.TotalBalance().ToString();
                        PurchaseDetails(Convert.ToInt32(loginId), pdestxtTN.Text, t.ToString(), pdeslblShowB.Text);
                      //  MessageBox.Show("Hi");
                    }

                }
                else
                {
                    MessageBox.Show("Ticket is not avaiable,all are sold");
                    PurchaseDetails(0, "", "", "");
                }
            }
            //setting null
            pdestxtST.Text = "";
            //// pdestxtTN.Text = "";
            // pdestxtDT.Text = "";
            // pdestxtAT.Text = "";
            // pdesdTP.Text = "";
            pdesrbtnFC.Checked = false;
            pdesrbtnN.Checked = false;

        }
        // After purched ticket
        int s1 = 0;
        string s2 = "";
        string s3 = "";
        string s4 = "";
        //Method
        public void PurchaseDetails(int id, string TName, string Totalticket, string balance)
        {
            this.s1 = id;
            this.s2 = TName;
            this.s3 = Totalticket;
            this.s4 = balance;

        }

        int h = 0;
        private void pnldestination_Paint(object sender, PaintEventArgs e)
        {


            pdesComboboxTQ.ResetText();
            pdescombobox.ResetText();

            if (h == 0)
            {
                pdesComboboxTQ.Items.Add("1");
                pdesComboboxTQ.Items.Add("2");
                pdesComboboxTQ.Items.Add("3");
                pdesComboboxTQ.Items.Add("4");
                h++;
            }

        }

        private void pdescombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TicketInfo tuser = new TicketInfo();
            String query = "SELECT [TName],[DTime],[ATime],[TicketPrice_tk] FROM[Train].[dbo].[trainschedule] WHERE [Destination]='" + pdescombobox.Text + "' ";


            try
            {

                SqlDataAdapter sda = dbc.DataAccess(query);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    // MessageBox.Show("please check given ticket information below ");
                    pdestxtST.Text = pdescombobox.Text;
                    pdestxtTN.Text = dt.Rows[0][0].ToString();
                    pdestxtDT.Text = dt.Rows[0][1].ToString();
                    pdestxtAT.Text = dt.Rows[0][2].ToString();
                    pdesdTP.Text = dt.Rows[0][3].ToString();


                    //working
                    int m = pdesComboboxTQ.SelectedIndex + 1;

                    TicketInfo tif = new TicketInfo(new string[] { pdestxtST.Text, pdestxtTN.Text, pdestxtDT.Text, pdestxtAT.Text, pdesdTP.Text, ticketType, m.ToString() });

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        string ticketType;

        private void pdesrbtnFC_CheckedChanged(object sender, EventArgs e)
        {
            ticketType = "FirstClass";
        }

        private void pdesrbtnN_CheckedChanged(object sender, EventArgs e)
        {
            ticketType = "Normal";
        }
        int totalNumberOfTicket;
        private void pdesComboboxTQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pdescombobox.SelectedIndex == -1 && pdesComboboxTQ.SelectedIndex == -1)
            {
                MessageBox.Show("Select your Total ticket!");
            }
            else
            {
                totalNumberOfTicket = pdesComboboxTQ.SelectedIndex;

                //  MessageBox.Show ( pdesComboboxTQ.SelectedIndex.ToString());
            }
        }

        private void btntrainList_Click(object sender, EventArgs e)
        {

            PanelVisibleFalse();
            this.Hide();
            new Information(lblstatus.Text, lbltbID.Text).Show();

        }
        string m = "";
        string n = "";

        private void pdesbtnconfirm_Click(object sender, EventArgs e)
        {
            if (s1 == 0 || s2 == "" || s3 == "" || s4 == "")
            {
                MessageBox.Show("Please at first Click on the purchase details button verification\n Otherwise purchase not success");
            }
            else
            {
                s2.ToString();
                s3.ToString();
                s4.ToString();
                String st = "INSERT INTO Ticket(id,TName,Totalticket,balance) VALUES('" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "')";
                SqlCommand cmd = new SqlCommand(st, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int val = cmd.ExecuteNonQuery();
                        MessageBox.Show("Purchase ticket successfully\nNumber of affected rows:" + val);
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
            //seat number
      
            if (s1 == 0 || s2 == "" || s3 == "" || s4 == "")
            {
                MessageBox.Show("Seat number not available witihout purchase details button successful");
            }
            else
            {
                String query = "SELECT ticketid,Totalticket FROM Ticket where id='" + s1 + "' and TName='" + s2 + "'";
                try
                {
                 
                    SqlDataAdapter sda = dbc.DataAccess(query);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                      //MessageBox.Show("Test2");
                        m = dt.Rows[0][0].ToString();
                        n = dt.Rows[0][1].ToString(); 
                        int i = Convert.ToInt32(m);
                        int j = Convert.ToInt32(n);
                        // working on seat number
                        if (j == 1)
                        {
                            pdeslbldisplay.Text = "Seat Number:1=id:" + m;

                        }
                        else
                        {
                            if (j == 2)
                                pdeslbldisplay.Text = "SeatNumber:1-2=id:" + m;
                            else if (j == 3)
                                pdeslbldisplay.Text = "SeatNumber:1-3=id:" + m;
                            else if (j == 4)
                                pdeslbldisplay.Text = "SeatNumber:1-4=id:" + m;
                            else if (j == 5)
                                pdeslbldisplay.Text = "SeatNumber:1-5=id:" + m;
                        }


                    }
                    //else
                    //{
                    //    MessageBox.Show("Not purchase!");
                    //}
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
             

            }
            s1 = 0;
            s2 = "";
            s3 = "";
            s4 = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////end 
    }
}

