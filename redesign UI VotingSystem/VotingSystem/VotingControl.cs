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
    public partial class VotingControl : Form
    {
        public VotingControl()
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


        private void VotingControl_Load(object sender, EventArgs e)
        {
           
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog(this);//Interface conversion function
        }

        private void Endbutton_Click(object sender, EventArgs e)
        {
            DBConnect();

            strsql = string.Format("update Voting set Statement = 0  where VoteName = '{0}'", comboBox1.Text);// Voting candidate's vote +1
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("Successfully Change.");//Displayed when the database connection is successful

            }
            catch
            {
                MessageBox.Show("Change Error.");//Displayed when the database connection is fail
            }
            //Check register
            finally
            {
                mycon.Close();//close the connection
            }
        }
    }
}
