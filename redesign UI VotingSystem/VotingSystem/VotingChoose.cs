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
        SqlConnection mycon;//open the database connection
        SqlCommand command;//Specify the SQL statement to execute
        DataSet DS;//rename dataset to DS
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
                return true;//Displayed when the database connection is successful
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;//Displayed when the database connection is fail
            }
        }

        private void GetStatement()
        {
            //Specify the SQL statement and stored procedure name to execute
            strsql = string.Format("select Statement from Voting Where VoteName = '{0}'", VoteNamecomboBox.Text);
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
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
                SV2.ShowDialog(this);//Interface conversion function
            }
            else if (VS == "0")
            {
                MessageBox.Show("Sorry Vote is closed");//show massage
            }
        }

        private void VotingChoose_Load(object sender, EventArgs e)
        {
           
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);
            DBConnect();//connect to the database
           

        }
    }
}
