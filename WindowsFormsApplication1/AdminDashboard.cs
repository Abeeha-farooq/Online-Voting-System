using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB__PROJECT
{
    public partial class AdminDashboard : Form
    {
        SqlConnection con = new SqlConnection(
             @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load; // load event attach
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            con.Open();

            // Total Voters
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM VOTER", con);
            lblTotalVoters.Text = cmd1.ExecuteScalar().ToString();

            // Total Votes
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM VOTE", con);
            lblTotalVotes.Text = cmd2.ExecuteScalar().ToString();

            // Total Elections
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM ELECTION", con);
            lblTotalElections.Text = cmd3.ExecuteScalar().ToString();

            // Winning Candidate
            SqlCommand cmd4 = new SqlCommand(@"
                SELECT TOP 1 c.name 
                FROM CANDIDATE c
                JOIN VOTE v ON c.candidate_id = v.candidate_id
                GROUP BY c.name
                ORDER BY COUNT(v.vote_id) DESC", con);

            object result = cmd4.ExecuteScalar();
            lblWinner.Text = result != null ? result.ToString() : "N/A";

            con.Close();
        }

        // ADD PARTY
        private void btnParty_Click(object sender, EventArgs e)
        {
            PartyForm f = new PartyForm();
            f.ShowDialog();
        }

        // ADD ELECTION
        private void btnElection_Click(object sender, EventArgs e)
        {
            ElectionForm f = new ElectionForm();
            f.ShowDialog();
        }

        // ADD CANDIDATE
        private void btnCandidates_Click(object sender, EventArgs e)
        {
            CandidateForm f = new CandidateForm();
            f.ShowDialog();
        }

        // VIEW RESULTS
        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsForm f = new ResultsForm();
            f.ShowDialog();
        }

        // LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }


        private void btnVoters_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voters module");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalVotes_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalElections_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalVoters_Click(object sender, EventArgs e)
        {

        }

        private void lblWinner_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}