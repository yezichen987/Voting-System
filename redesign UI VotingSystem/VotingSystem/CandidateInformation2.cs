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
    public partial class CandidateInformation2 : Form
    {
        public CandidateInformation2()
        {
            InitializeComponent();

            if (LoginInfo.CurrentUser.UserName == "")
            {
                label3.Text = "Visitor";
            }
            else {
                string msg = string.Format("Voter:{0}", LoginInfo.CurrentUser.UserName);
                //get Voter username from the logininfo class
                label3.Text = msg;
            }
                
        }

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet DS;
        SqlDataAdapter DA;
        public string str;
        string key;
        //connect to database
        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                //Instantiate an object connected to a database
                mycon = new SqlConnection(strcon);
                //Open database connection
                mycon.Open();
                //MessageBox.Show("DB Connect is good");
                return true;
                //Displayed when the database connection is successful
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
                //Displayed when the database connection is fail
            }
        }
        
        private void showDataGrid()
        {
            strsql = string.Format("select Name,VoteName from Candidate Where VoteName = '{0}'", comboBox1.Text);

            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
            //Get the information needed for the form from the database
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
            //Get the information needed for the form from the database
        }

        private void CandidateInformation2_Load(object sender, EventArgs e)
        {
            
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);
            timer1.Interval = 1000;
            // time update every 1 second
            timer1.Start();
            // time start
            DBConnect();
            //Perform a time event every 1000 milliseconds

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellvalue = DGV1.SelectedCells[0].Value.ToString();
            textBox1.Text = cellvalue;
            // click event, to show the information into textbox
        }

        private void Getbutton_Click(object sender, EventArgs e)
        {
            Public.CandidateName.ChooseCandidate = textBox1.Text;
            CandidateIntroduction1 CINTRO = new CandidateIntroduction1();
            this.Hide();
            CINTRO.ShowDialog(this);
            //Interface conversion function
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.ShowDialog(this);
            //Interface conversion function,back to the homepage
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //display the datetime
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDataGrid();
            // datagrid show data
            DGV1.RowHeadersVisible = false;
        }


    }
}
