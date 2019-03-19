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
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
            }
        }
        private bool check()
        {
            if (UsernametextBox.Text.Length == 0)
            {
                UsernametextBox.Select();
                return false;
            }
            if (PasswordtextBox.Text.Length == 0)
            {
                UsernametextBox.Select();
                return false;
            }
         
            
            
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
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
        }

        private void Register_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect();
            strsql = string.Format("insert into Voter(Name,Password) values('{0}','{1}')",UsernametextBox.Text,PasswordtextBox.Text);
            MessageBox.Show(strsql);
            command = new SqlCommand(strsql, mycon);
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("Register successful");
                Login login = new Login();
                this.Hide();
                login.ShowDialog(this);
            }
            catch
            {
                MessageBox.Show("Register failed");
            }
            finally
            {
                mycon.Close();
            }
        }
    }
}
