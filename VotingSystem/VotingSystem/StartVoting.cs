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
using System.Data.SqlClient;
namespace VotingSystem
{
    public partial class StartVoting : Form
    {
        public StartVoting()
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        private bool DBConnect()
        {
            try
            {
               // strcon = " Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                strcon = " Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                /*Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True*/
                mycon = new SqlConnection(strcon);
                mycon.Open();
                MessageBox.Show("DB Connect is good");
                return true;
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void StartVoting_Load(object sender, EventArgs e)
        {
            if (button1.Text == "Submit") {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '1'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton1.Text = temp_role;
            }
            if (button1.Text == "Submit")
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '2'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton2.Text = temp_role;
            }
            if (button1.Text == "Submit")
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '3'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton3.Text = temp_role;
            }
            if (button1.Text == "Submit")
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '4'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton4.Text = temp_role;
            }
            if (button1.Text == "Submit")
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '5'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton5.Text = temp_role;
            }
            if (button1.Text == "Submit")
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                sqlconn.Open();
                SqlCommand cmd = sqlconn.CreateCommand();
                cmd.CommandText = "select Name from Candidate where Id = '6'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string temp_role = reader.GetString(0);
                sqlconn.Close();
                radioButton6.Text = temp_role;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '1'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
            if (radioButton2.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '2'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
            if (radioButton3.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '3'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
            if (radioButton4.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '4'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
            if (radioButton5.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '5'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
            if (radioButton6.Checked = true)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Id = '6'");// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
            }
        }
    }
}
