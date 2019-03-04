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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        private bool DBConnect()
        {
            try
            {
                strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";

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
            if (UserNametextBox.Text.Length == 0)
            {
                UserNametextBox.Select();
                return false;
            }
            if (PasswordtextBox.Text.Length == 0)
            {
                UserNametextBox.Select();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check() && DBConnect())
            {
                strsql = string.Format("select count (*) from Voter where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordtextBox.Text);
                command = new SqlCommand(strsql, mycon);
                try
                {
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if (result > 0)
                    {
                        MessageBox.Show("successful login");
                       
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                catch
                {
                    MessageBox.Show("Sql error");
                }
            }
        }
    }
}
