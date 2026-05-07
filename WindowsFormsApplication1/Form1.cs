using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB__PROJECT
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        bool isFormReady = false;   // 🔥 important flag

        public Form1()
        {
            InitializeComponent();

            //  manually bind events (safe)
            this.Load += Form1_Load;
            rbAdmin.CheckedChanged += rbAdmin_CheckedChanged;
            rbVoter.CheckedChanged += rbVoter_CheckedChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbAdmin.Checked = false;
            rbVoter.Checked = false;

            rbAdmin.AutoCheck = false;
            rbVoter.AutoCheck = false;

            lblCNIC.Visible = false;
            lblEmail.Visible = false;
            lblPassword.Visible = false;

            txtEmail.Visible = false;
            txtPassword.Visible = false;
            txtCNIC.Visible = false;

            rbAdmin.AutoCheck = true;
            rbVoter.AutoCheck = true;

            isFormReady = true;   
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (!isFormReady) return;   // 🔥 stop auto firing

            if (rbAdmin.Checked)
            {
                txtEmail.Visible = true;
                txtPassword.Visible = true;
                lblCNIC.Visible = false;
                lblEmail.Visible = true;
                lblPassword.Visible = true;

                txtCNIC.Visible = false;
            }
        }

        private void rbVoter_CheckedChanged(object sender, EventArgs e)
        {
            if (!isFormReady) return;   // 🔥 stop auto firing

            if (rbVoter.Checked)
            {
                txtCNIC.Visible = true;

                txtEmail.Visible = false;
                txtPassword.Visible = false;

                lblCNIC.Visible = true;
                lblEmail.Visible = false;
                lblPassword.Visible = false;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // 🔴 ADMIN LOGIN
                if (rbAdmin.Checked)
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT user_id FROM USERS WHERE email=@e AND password=@p AND user_type='ADMIN'", con);

                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Admin Login Successful");

                        AdminDashboard ad = new AdminDashboard();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin Credentials ❌");
                    }

                    dr.Close();
                }

                // 🟢 VOTER LOGIN
                else if (rbVoter.Checked)
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT voter_id, constituency_id FROM VOTER WHERE cnic=@c", con);

                    cmd.Parameters.AddWithValue("@c", txtCNIC.Text.Trim());

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int voterId = Convert.ToInt32(dr["voter_id"]);
                        int constituencyId = Convert.ToInt32(dr["constituency_id"]);

                        MessageBox.Show("Voter Login Successful");

                        VoterDashboard vd = new VoterDashboard(voterId, constituencyId);
                        vd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid CNIC ❌");
                    }

                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Please select Admin or Voter");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}