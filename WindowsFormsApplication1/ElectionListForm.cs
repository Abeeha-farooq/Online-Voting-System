using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB__PROJECT
{
    public partial class ElectionListForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");

        public ElectionListForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Load += ElectionListForm_Load;
        }

        //  FORM LOAD EVENT
        private void ElectionListForm_Load(object sender, EventArgs e)
        {

            LoadElections();
        }

        void LoadElections()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM active_elections_view", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // REFRESH BUTTON TO GET UPDATED DATA
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadElections();
        }
    }
}