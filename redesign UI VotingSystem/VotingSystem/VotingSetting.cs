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
    public partial class VotingSetting : Form
    {
        public VotingSetting()
        {
            InitializeComponent();
            string msg = string.Format("Admin:{0}", LoginInfo.CurrentUser.UserName);
            label3.Text = msg;
        }
        string strcon, strsql;//open the database connection
        SqlConnection mycon;//open the database connection
        SqlCommand command;//open the database connection
        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";

                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";

                mycon = new SqlConnection(strcon);
                mycon.Open();//open the database connection
                MessageBox.Show("DB Connect is good");
                return true;//Displayed when the database connection is successful
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;//Displayed when the database connection is fail
            }
        }
        private bool check()
        {
            if (comboBox1.Text.Length == 0)
            {
                comboBox1.Select();
                return false;//If the text box in the text box is equal to zero, an error message is returned
            }
            if (comboBox2.Text.Length == 0)
            {
                comboBox2.Select();
                return false;//If the text box in the text box is equal to zero, an error message is returned
            }
            return true;//If the text box in the text box is not equal to zero, a correct message is returned
        }
        private int totalSecond = 7198;
        private int tenthSecond = 9;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            HomePage homePage = new HomePage(textBox1.Text);
            //open the database connection
            DBConnect();
            strsql = string.Format("insert into Voting(VoteName,Time,VoterLimit,CandidateNum,Statement) values('{0}','{1}','{2}','{3}',1)", textBox2.Text,textBox1.Text, comboBox1.Text,comboBox2.Text);
            MessageBox.Show(strsql);//show message
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            try
            {
                command.ExecuteScalar();//Loop the entire object
                MessageBox.Show("Save successful");
                
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog(this);//Interface conversion function

            }
            catch
            {
                MessageBox.Show("Save failed");//show message
            }
            finally
            {
                mycon.Close();//close the connection
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog(this);//Interface conversion function
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();//get datetime
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VotingSetting_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
            timer1.Interval = 1000; //Perform a time event every 1000 milliseconds
            timer1.Start();
           // this.timer1.Stop();
           
        }
    }
}
