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
            this.StartPosition = FormStartPosition.CenterScreen;

            voterId = vId;
            constituencyId = cId;

            this.Load += VotingForm_Load;
        }

        // FORM LOAD
        private void VotingForm_Load(object sender, EventArgs e)
        {
            LoadElections();
        }

        // LOAD ELECTIONS
        private void LoadElections()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT election_id, title FROM ELECTION WHERE status='Ongoing'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbElection.DataSource = null;
            cmbElection.DisplayMember = "";
            cmbElection.ValueMember = "";

            cmbElection.DataSource = dt;
            cmbElection.DisplayMember = "title";
            cmbElection.ValueMember = "election_id";

            // 🔥 IMPORTANT FIX: use correct event
            cmbElection.SelectionChangeCommitted -= cmbElection_SelectionChangeCommitted;
            cmbElection.SelectionChangeCommitted += cmbElection_SelectionChangeCommitted;

            if (dt.Rows.Count > 0)
                cmbElection.SelectedIndex = 0;
            
        }

        // ELECTION CHANGE EVENT (FIXED)
        private void cmbElection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCandidates();
        }

        // LOAD CANDIDATES
        private void LoadCandidates()
        {
            MessageBox.Show("EID = " + cmbElection.SelectedValue +
                "\nCID = " + constituencyId);

            if (cmbElection.SelectedValue == null)
                return;

            int eid;

            if (!int.TryParse(cmbElection.SelectedValue.ToString(), out eid))
                return;

            SqlDataAdapter da = new SqlDataAdapter(
     @"SELECT candidate_id, name
      FROM CANDIDATE
      WHERE election_id = @eid", con);

            da.SelectCommand.Parameters.AddWithValue("@eid", eid);
            da.SelectCommand.Parameters.AddWithValue("@cid", constituencyId);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCandidate.DataSource = null;
            cmbCandidate.DataSource = dt;
            cmbCandidate.DisplayMember = "name";
            cmbCandidate.ValueMember = "candidate_id";

            cmbCandidate.SelectedIndex = -1;

        }

        // VOTE BUTTON
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

                // CHECK ALREADY VOTED
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

                // INSERT VOTE
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

        // OPTIONAL (NOT USED BUT SAFE)
        private void cmbCandidate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}