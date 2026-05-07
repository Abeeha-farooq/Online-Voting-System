using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB__PROJECT
{
    public partial class ElectionForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Server=.\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;");

        public ElectionForm()
        {
            InitializeComponent();
        }

        // ================= ADD ELECTION =================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dtEnd.Value <= dtStart.Value)
                {
                    MessageBox.Show("End time must be greater than start time ❌");
                    return;
                }

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO ELECTION
                    (election_id, title, election_date, start_time, end_time, status)
                    VALUES (@id,@title,@date,@start,@end,@status)", con);

                cmd.Parameters.AddWithValue("@id", GetNextId());
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@date", dtDate.Value.Date);
                cmd.Parameters.AddWithValue("@start", dtStart.Value);
                cmd.Parameters.AddWithValue("@end", dtEnd.Value);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Election Added ");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // AUTO ID 
        int GetNextId()
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(election_id),0)+1 FROM ELECTION", con);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void ElectionForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}