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

        private void showDataGrid()
        {
            strsql = string.Format("select Name, Information, VoteNum from Candidate Where VoteName = '{0}'", comboBox1.Text);

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

        private void GetEndTime()
        {
            strsql = string.Format("select Time from Voting Where VoteName = '{0}'", comboBox1.Text);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String time = DS.Tables[0].Rows[0]["Time"].ToString();
            TimeLabel.Text = time;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDataGrid();
            GetEndTime();
            GetNum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserName == "admin1")
            {
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog(this);
            }
            else
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.ShowDialog(this);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
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
