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
    public partial class ManageVotingStatement : Form
    {
        public ManageVotingStatement()
        {
            InitializeComponent();
            if(LoginInfo.CurrentUser.UserName == "")
            {
                label3.Text = "Visitor";
            }
            else { 
            string msg = string.Format("{0}", LoginInfo.CurrentUser.UserName);
            label3.Text = msg;
            }
        }
        VotingSetting votingSetting;

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet DS;
        SqlDataAdapter DA;
        public string str;
        string key;
        //connect to the database
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
            strsql = string.Format("select Name, Information, VoteNum from Candidate Where VoteName = '{0}'", comboBox1.Text);
            //connect to the database
            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
            //show data to the table
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
            //show data to the table
        }

        private void GetEndTime()
        {
            strsql = string.Format("select Time from Voting Where VoteName = '{0}'", comboBox1.Text);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String time = DS.Tables[0].Rows[0]["Time"].ToString();
            TimeLabel.Text = time;
            //get the end time from the timelabel
        }

        private void GetNum()
        {
            strsql = string.Format("select VoterLimit from Voting Where VoteName = '{0}'", comboBox1.Text);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String VL = DS.Tables[0].Rows[0]["VoterLimit"].ToString();
            Numlabel.Text = VL;
            //get number from the number label
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDataGrid();
            GetEndTime();
            GetNum();//get the time,number data from table
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserName == "admin1")
            {
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog(this);
                //Interface conversion function
            }
            else
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.ShowDialog(this);
                //Interface conversion function
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //get the time
        }

        private void ManageVotingStatement_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“votingDataSet.Voting”中。您可以根据需要移动或删除它。
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);
            DBConnect();
            timer1.Interval = 1000;
            timer1.Start();
            label1.Text = DateTime.Now.ToString();
        }
    }
}
