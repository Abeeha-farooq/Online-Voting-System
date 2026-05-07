using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB__PROJECT
{
    public partial class VotingForm : Form
    {
        int voterId;
        int constituencyId;

        SqlConnection con = new SqlConnection(
            @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public VotingForm(int vId, int cId)
        {
            InitializeComponent();
            voterId = vId;
            constituencyId = cId;

            this.Load += VotingForm_Load;
        }

        // ================= FORM LOAD =================
        private void VotingForm_Load(object sender, EventArgs e)
        {
            LoadElections();
        }

        // ================= ELECTION LOAD =================
        private void LoadElections()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT election_id, title FROM ELECTION WHERE status='Ongoing'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbElection.SelectedIndexChanged -= cmbElection_SelectedIndexChanged;

            cmbElection.DataSource = dt;
            cmbElection.DisplayMember = "title";
            cmbElection.ValueMember = "election_id";

            cmbElection.SelectedIndexChanged += cmbElection_SelectedIndexChanged;

            if (dt.Rows.Count > 0)
            {
                cmbElection.SelectedIndex = 0;
                LoadCandidates(); // safe call
            }
        }

        // ================= ELECTION CHANGE =================
        private void cmbElection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCandidates();
        }

        // ================= CANDIDATES LOAD =================
        private void LoadCandidates()
        {
            if (cmbElection.SelectedValue == null) return;
            if (cmbElection.SelectedValue is DataRowView) return;

            int eid = Convert.ToInt32(cmbElection.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT candidate_id, name 
                  FROM CANDIDATE 
                  WHERE election_id = @eid 
                  AND constituency_id = @cid", con);

            da.SelectCommand.Parameters.AddWithValue("@eid", eid);
            da.SelectCommand.Parameters.AddWithValue("@cid", constituencyId);

            DataTable dt = new DataTable();
            da.Fill(dt);

            // 🔥 DEBUG (IMPORTANT)
            MessageBox.Show("Candidates Found: " + dt.Rows.Count);

            cmbCandidate.DataSource = dt;
            cmbCandidate.DisplayMember = "name";
            cmbCandidate.ValueMember = "candidate_id";
        }

        // ================= VOTE =================
        private void btnVote_Click(object sender, EventArgs e)
        {
            if (cmbCandidate.SelectedValue == null || cmbElection.SelectedValue == null)
            {
                MessageBox.Show("Select election and candidate first.");
                return;
            }

            try
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM VOTE WHERE voter_id=@v AND election_id=@e", con);

                checkCmd.Parameters.AddWithValue("@v", voterId);
                checkCmd.Parameters.AddWithValue("@e", cmbElection.SelectedValue);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Already voted!");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO VOTE (voter_id, candidate_id, election_id) VALUES (@v,@c,@e)", con);

                cmd.Parameters.AddWithValue("@v", voterId);
                cmd.Parameters.AddWithValue("@c", cmbCandidate.SelectedValue);
                cmd.Parameters.AddWithValue("@e", cmbElection.SelectedValue);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Vote Cast Successfully");
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
    }
}