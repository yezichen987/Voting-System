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
                strcon = " Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                /*Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True*/
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
            if (PasswordBox.Text.Length == 0)
            {
                UserNametextBox.Select();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (check() && DBConnect())
                {
                if(VoterradioButton.Text == "Voter")
                {
                    strsql = string.Format("select count (*) from Voter where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        int result = Convert.ToInt32(command.ExecuteScalar());
                        if (result > 0)
                        {
                            MessageBox.Show("successful login");
                            
                           
                            
                            LoginInfo.CurrentUser.UserName = UserNametextBox.Text;
                            HomePage HomePage = new HomePage();
                            this.Hide();
                            HomePage.ShowDialog(this);
                        }
                        else
                        {
                           // MessageBox.Show("Login failed");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sql error");
                    }
                }
                
                     if (AuditorradioButton.Text == "Auditor")
                    {
                        strsql = string.Format("select count (*) from Auditor where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                        command = new SqlCommand(strsql, mycon);
                        try
                        {
                            int result = Convert.ToInt32(command.ExecuteScalar());
                            if (result > 0)
                            {
                                MessageBox.Show("successful login");

                                LoginInfo.CurrentUser.UserName = UserNametextBox.Text;
                                AuditorChoose auditorMenu = new AuditorChoose();
                                this.Hide();
                                auditorMenu.ShowDialog(this);
                            }
                            else
                            {
                               // MessageBox.Show("Login failed");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sql error");
                        }
                    
                }
               
                     if(AdminradioButton.Text == "Admin")
                    {
                        strsql = string.Format("select count (*) from Admin where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                        command = new SqlCommand(strsql, mycon);
                        try
                        {
                            int result = Convert.ToInt32(command.ExecuteScalar());
                            if (result > 0)
                            {
                                MessageBox.Show("successful login");

                                LoginInfo.CurrentUser.UserName = UserNametextBox.Text;
                                AdminMenu adminmenu = new AdminMenu();
                                this.Hide();
                                adminmenu.ShowDialog(this);
                            }
                            else
                            {
                                //MessageBox.Show("Login failed");
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
}
