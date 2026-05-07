using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB__PROJECT
{
    public partial class VoterDashboard : Form

    {
        int currentUserId;
        int CNIC_ID;
        SqlConnection con = new SqlConnection(
        @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public VoterDashboard(int voterID,int constituencyId)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
             currentUserId=voterID;
            CNIC_ID = constituencyId;
        }


        private void btnViewElections_Click(object sender, EventArgs e)
        {
            ElectionListForm f = new ElectionListForm();
            f.Show();
        }


        private void btnCastVote_Click(object sender, EventArgs e)
        {
            VotingForm f = new VotingForm(currentUserId, CNIC_ID);
            f.Show();
        }


        private void btnViewResults_Click(object sender, EventArgs e)
        {
            ResultsForm f = new ResultsForm();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }


    }
}