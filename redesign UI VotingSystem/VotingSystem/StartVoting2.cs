﻿using System;
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
            string msg = string.Format("{0}", LoginInfo.CurrentUser.UserName);
            Userlabel.Text = msg;
        }

        string strcon, strsql;
        SqlConnection mycon;//open the database connection
        SqlCommand command;//Specify the SQL statement to execute
        DataSet DS;//rename dataset to DS
        SqlDataAdapter DA;
        public string str;
        string key;

        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);//Specify the SQL statement to execute
                mycon.Open();
                //MessageBox.Show("DB Connect is good");
                return true;//Displayed when the database connection is successful
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;//Displayed when the database connection is fail
            }
        }

        private void showNote()
        {
            strsql = string.Format("select Introduction from Voting Where VoteName = '{0}'", Public.VoteName.ChooseVote);
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String Intro = DS.Tables[0].Rows[0]["Introduction"].ToString();
            Notelabel.Text = "Note: " + Intro;
        }

        private void showDataGrid()
        {
            strsql = string.Format("select Name, VoteName,VoteNum from Candidate Where VoteName = '{0}'", Public.VoteName.ChooseVote);
            //open the database connection
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            command.ExecuteScalar();//Loop the entire object
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }
        private void showDataGrid(string sqlco)
        {
            strsql = sqlco;
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            MessageBox.Show(strsql);
            command.ExecuteScalar();//Loop the entire object
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }

        private void StartVoting2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            DBConnect();
                showDataGrid();
                 showNote();
                DGV1.RowHeadersVisible = false;

            key = DGV1.CurrentRow.Cells[1].Value.ToString();
            radioButton1.Text = DGV1.Rows[0].Cells[0].Value.ToString();
            radioButton2.Text = DGV1.Rows[1].Cells[0].Value.ToString();
            radioButton3.Text = DGV1.Rows[2].Cells[0].Value.ToString();
            radioButton4.Text = DGV1.Rows[3].Cells[0].Value.ToString();
            radioButton5.Text = DGV1.Rows[4].Cells[0].Value.ToString();
            radioButton6.Text = DGV1.Rows[5].Cells[0].Value.ToString();
           
         
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string cellvalue = DGV1.SelectedCells[0].Value.ToString();
            //checkBox1.Text = cellvalue;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //Open database connection
                DBConnect();
                
                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton1.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function
                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection
                }
            }
            if (radioButton2.Checked)
            {
                //Open database connection
                DBConnect();

                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton2.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function
                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection
                }
            }
            if (radioButton3.Checked)
            {
                //Open database connection
                DBConnect();

                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton3.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function
                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection
                }
            }
            if (radioButton4.Checked)
            {
                //Open database connection
                DBConnect();

                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton4.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function
                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection
                }
            }
            if (radioButton5.Checked)
            {
                //Open database connection
                DBConnect();

                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton5.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function

                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection
                }
            }
            if (radioButton6.Checked)
            {
                //Open database connection
                DBConnect();

                //Specify the SQL statement and stored procedure name to execute
                strsql = string.Format("update Candidate set VoteNum = VoteNum +1 where Name = '{0}'", radioButton6.Text);// Voting candidate's vote +1
                command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                try
                {
                    command.ExecuteScalar();//Loop the entire object
                    MessageBox.Show("Successfully Voting.");

                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog(this);//Interface conversion function
                }
                catch
                {
                    MessageBox.Show("Voting Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();//close the connection

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString();//show datetime
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {
            DBConnect();//connect to the database
            showDataGrid();
            int count = DS.Tables["Candidate"].Rows.Count;
            mycon.Close();//close the connection
        }


    }
}
