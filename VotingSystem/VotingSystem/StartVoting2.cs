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
using System.Windows.Forms.DataVisualization.Charting;

namespace VotingSystem
{
    public partial class StartVoting2 : Form
    {
        public StartVoting2()
        {
            InitializeComponent();
        }

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet DS;
        SqlDataAdapter DA;
        public string str;
        string key;

        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);
                mycon.Open();
                //MessageBox.Show("DB Connect is good");
                return true;
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
            }
        }

        private void showNote()
        {
            strsql = string.Format("select Introduction from Voting Where VoteName = '{0}'", Public.VoteName.ChooseVote);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String Intro = DS.Tables[0].Rows[0]["Introduction"].ToString();
            Notelabel.Text = "Note: " + Intro;
        }

        private void showDataGrid()
        {
            strsql = string.Format("select * from Candidate Where VoteName = '{0}'", Public.VoteName.ChooseVote);

            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }
        private void showDataGrid(string sqlco)
        {
            strsql = sqlco;
            command = new SqlCommand(strsql, mycon);
            MessageBox.Show(strsql);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }

        private void StartVoting2_Load(object sender, EventArgs e)
        {
            

                DBConnect();
                showDataGrid();
                 showNote();
                DGV1.RowHeadersVisible = false;

            key = DGV1.CurrentRow.Cells[1].Value.ToString();
            checkBox1.Text = DGV1.Rows[0].Cells[1].Value.ToString();
            checkBox2.Text = DGV1.Rows[1].Cells[1].Value.ToString();
            checkBox3.Text = DGV1.Rows[2].Cells[1].Value.ToString();
            checkBox4.Text = DGV1.Rows[3].Cells[1].Value.ToString();
            checkBox5.Text = DGV1.Rows[4].Cells[1].Value.ToString();
            checkBox6.Text = DGV1.Rows[5].Cells[1].Value.ToString();
           
         
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string cellvalue = DGV1.SelectedCells[0].Value.ToString();
            //checkBox1.Text = cellvalue;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                DBConnect();
                
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox1.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
            if (checkBox2.Checked)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox2.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
            if (checkBox3.Checked)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox3.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
            if (checkBox4.Checked)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox4.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
            if (checkBox5.Checked)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox5.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
            if (checkBox6.Checked)
            {
                DBConnect();
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", checkBox6.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);
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
        private void update_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            int count = DS.Tables["Candidate"].Rows.Count;
            mycon.Close();
        }


    }
}
