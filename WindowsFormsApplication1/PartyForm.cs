using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB__PROJECT
{
    public partial class PartyForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public PartyForm()
        {
            InitializeComponent();
        }

        // ADD PARTY
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(
                @"Server=.\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO PARTY 
                (party_id, name, symbol, leader_name, founded_year, headquarters)
                VALUES (@id,@name,@symbol,@leader,@year,@hq)", con);

                    cmd.Parameters.AddWithValue("@id", GetNextId());
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@symbol", txtSymbol.Text);
                    cmd.Parameters.AddWithValue("@leader", txtLeader.Text);
                    cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtYear.Text));
                    cmd.Parameters.AddWithValue("@hq", txtHQ.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Party Added Successfully 🎉");
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // LOAD GRID
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM PARTY", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvParty.DataSource = dt;

                con.Close();
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
                "SELECT ISNULL(MAX(party_id),0)+1 FROM PARTY", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int id = (int)cmd.ExecuteScalar();

            con.Close();
            return id;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}