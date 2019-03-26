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
    public partial class VoterInformation : Form
    {
        public VoterInformation()
        {
            InitializeComponent();
        }

        string strcon, strsql;
        SqlConnection mycon;//open the database connection
        SqlCommand command;//Specify the SQL statement to execute
        DataSet DS;//rename dataset to DS
        SqlDataAdapter DA;
        public string str;

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

        private void VoterInformation_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label2.Text = LoginInfo.CurrentUser.UserName;
            DBConnect();//open the connection
            GetUserName();
            GetPassword();
        }

        private void GetUserName()
        {
           

            //Specify the SQL statement and stored procedure name to execute
            strsql = string.Format("select Name from Voter Where Name = '{0}'", label2.Text);

            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String name = DS.Tables[0].Rows[0]["Name"].ToString();
            Usernamelabel.Text = name;//get username
        }

        private void GetPassword()
        {
            //Specify the SQL statement and stored procedure name to execute
            strsql = string.Format("select Password from Voter Where Name = '{0}'", label2.Text);

            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            DA = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            String password = DS.Tables[0].Rows[0]["Password"].ToString();
            PasswordtextBox.Text = password;//int password
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog(this);//Interface conversion function
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);//Interface conversion function
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect();
            //Specify the SQL statement and stored procedure name to execute
            strsql = string.Format("update Voter set Password = '{0}' where Name = '{1}' ", PasswordtextBox.Text,label2.Text);
           
            MessageBox.Show(strsql);
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("Register successful");
                Login login = new Login();
                this.Hide();
                login.ShowDialog(this);//Interface conversion function
            }
            catch
            {
                MessageBox.Show("Register failed");//show register result
            }
            finally
            {
                mycon.Close();//close the connection
            }
        }
    }
}
