using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB__PROJECT
{
    public partial class ResultsForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public ResultsForm()
        {
            InitializeComponent();
            this.Load += ResultsForm_Load; 
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
                   SELECT 
    c.candidate_id,
    c.name AS CandidateName,
    c.party_id,
    c.election_id,
    COUNT(v.vote_id) AS TotalVotes
FROM Candidate c
LEFT JOIN Vote v 
    ON c.candidate_id = v.candidate_id 
    AND c.election_id = v.election_id
GROUP BY 
    c.candidate_id,
    c.name,
    c.party_id,
    c.election_id;", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

                //  delay ensure grid fully binds
                dataGridView1.Refresh();

                ShowWinner();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ShowWinner()
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data found in grid!");
                return;
            }

            int maxVotes = -1;
            string winner = "No Winner";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["TotalVotes"].Value == null) continue;

                int votes;
                if (!int.TryParse(row.Cells["TotalVotes"].Value.ToString(), out votes))
                    continue;

                string name = row.Cells["CandidateName"].Value?.ToString();
                if (string.IsNullOrEmpty(name)) continue;

                if (votes > maxVotes)
                {
                    maxVotes = votes;
                    winner = name;
                }
            }

            MessageBox.Show("Winner: " + winner + " with " + maxVotes + " votes");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        }
