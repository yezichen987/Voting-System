using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VotingSystem
{
    public partial class StartVoting : Form
    {
        public StartVoting()
        {
            InitializeComponent();
        }
      
       
       
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void StartVoting_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandText = "select Name from Candidate where Id = '1'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string temp_role = reader.GetString(0);
            sqlconn.Close();
            label4.Text = temp_role;

        }
    }
}
