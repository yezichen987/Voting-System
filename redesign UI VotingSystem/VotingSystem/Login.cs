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
        SqlCommand command;//Specify the SQL statement to execute
        private bool DBConnect()
        {
            try
            {
                strcon = " Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                /*Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True*/
                mycon = new SqlConnection(strcon);
                mycon.Open();
                // connection open
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
        //Ensure that the textbox is not blank and save the data
        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog(this);
            //Interface conversion function
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            //Perform a time event every 1000 milliseconds
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog(this);
            //Interface conversion function
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //display the datetime
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (check() && DBConnect())//check the database connection
                {
                if(VoterradioButton.Text == "Voter" && VoterradioButton.Checked)//check the text is correct
                {
                    strsql = string.Format("select count (*) from Voter where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                    command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
                    try
                    {
                        int result = Convert.ToInt32(command.ExecuteScalar());
                        if (result > 0)
                        {
                            MessageBox.Show("successful login");
                            //if username and password are correct, show successful login in the messagebox
                           
                            
                            LoginInfo.CurrentUser.UserName = UserNametextBox.Text;//check the text correct
                            HomePage HomePage = new HomePage();
                            this.Hide();
                            HomePage.ShowDialog(this);
                            //Interface conversion function
                        }
                        else
                        {
                            MessageBox.Show("Login failed");//show results
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sql error");//show results
                    }
                }
                
                else if (AuditorradioButton.Text == "Auditor" && AuditorradioButton.Checked)//check the text are correct
                    {
                        strsql = string.Format("select count (*) from Auditor where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                        command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
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
                                MessageBox.Show("Login failed");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sql error");
                        }
                    
                }
                
                else if (AdminradioButton.Text == "Admin"&& AdminradioButton.Checked)
                    {
                        strsql = string.Format("select count (*) from Admin where Name = '{0}' and Password = '{1}'", UserNametextBox.Text, PasswordBox.Text);
                        command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
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
}
