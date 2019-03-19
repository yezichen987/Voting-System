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
    public partial class VotingChoose : Form
    {
        public VotingChoose()
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
        string VS;

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

        private void GetStatement()
        {
            strsql = string.Format("select Statement from Voting Where VoteName = '{0}'", VoteNamecomboBox.Text);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String vs = DS.Tables[0].Rows[0]["Statement"].ToString();
            VS = vs;
        }

        private void Choosebutton_Click(object sender, EventArgs e)
        {
            GetStatement();
            if (VS == "1")
            {
                Public.VoteName.ChooseVote = VoteNamecomboBox.Text;

                StartVoting2 SV2 = new StartVoting2();
                this.Hide();
                SV2.ShowDialog(this);
            }
            else if (VS == "0")
            {
                MessageBox.Show("Sorry Vote is closed");
            }
        }

        private void VotingChoose_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“votingDataSet.Voting”中。您可以根据需要移动或删除它。
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);
            DBConnect();
           

        }
    }
}
