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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet ds;
        SqlDataAdapter da;
        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);
                mycon.Open();
                MessageBox.Show("DB Connect is good");
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
        private bool check()
        {
            if (UsernametextBox.Text.Length == 0)
            {
                UsernametextBox.Select();
                return false;//check textbox is not blank
            }
            if (PasswordtextBox.Text.Length == 0)
            {
                UsernametextBox.Select();
                return false;//check textbox is not blank
            }
         
            
            
            return true;
        }

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog(this);
            //Interface conversion function
        }

        private void Register_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            //Perform a time event every 1000 milliseconds
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString();//get the time
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open database connection
            DBConnect();
            //Specify the SQL statement and stored procedure name to execute
            strsql = string.Format("insert into Voter(Name,Password) values('{0}','{1}')",UsernametextBox.Text,PasswordtextBox.Text);
            MessageBox.Show(strsql);//show message from the database
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("Register successful");
                Login login = new Login();
                this.Hide();
                login.ShowDialog(this);//save the user data and conversion interface
            }
            catch
            {
                MessageBox.Show("Register failed");//show information
            }
            finally
            {
                mycon.Close();//database connection closed
            }
        }
    }
}
