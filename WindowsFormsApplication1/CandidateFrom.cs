using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace DB__PROJECT
{
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
           
        }

        SqlConnection con = new SqlConnection(
            @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            LoadParties();
            LoadElections();
        }

        private void LoadParties()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT party_id, name FROM PARTY", con);  // 🔥 FIXED

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbParty.DataSource = dt;
            cmbParty.DisplayMember = "name";       
            cmbParty.ValueMember = "party_id";
        }

        private void LoadElections()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT election_id, title FROM ELECTION", con);  

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbElection.DataSource = dt;
            cmbElection.DisplayMember = "title";    
            cmbElection.ValueMember = "election_id";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbParty.SelectedValue == null || cmbElection.SelectedValue == null)
                {
                    MessageBox.Show("Select Party and Election first");
                    return;
                }

                int age;
                int constituencyId;

                if (!int.TryParse(txtAge.Text, out age))
                {
                    MessageBox.Show("Invalid Age");
                    return;
                }

                if (!int.TryParse(txtConstituencyID.Text, out constituencyId))
                {
                    MessageBox.Show("Invalid Constituency ID");
                    return;
                }

                con.Open();

                SqlCommand getIdCmd = new SqlCommand(
                    "SELECT ISNULL(MAX(candidate_id),0) + 1 FROM CANDIDATE", con);

                int newId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO CANDIDATE 
            (candidate_id, name, age, manifesto, party_id, election_id, constituency_id)
            VALUES 
            (@id, @n, @a, @m, @p, @e, @c)", con);

                cmd.Parameters.AddWithValue("@id", newId);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@a", age);
                cmd.Parameters.AddWithValue("@m", txtManifesto.Text);
                cmd.Parameters.AddWithValue("@p", cmbParty.SelectedValue);
                cmd.Parameters.AddWithValue("@e", cmbElection.SelectedValue);
                cmd.Parameters.AddWithValue("@c", constituencyId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Candidate Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CandidateForm_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}