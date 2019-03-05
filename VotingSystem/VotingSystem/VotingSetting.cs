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
            if (comboBox1.Text.Length == 0)
            {
                comboBox1.Select();
                return false;
            }
            if (comboBox2.Text.Length == 0)
            {
                comboBox2.Select();
                return false;
            }
            return true;
        }
        private int totalSecond = 7198;
        private int tenthSecond = 9;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DBConnect();
            strsql = string.Format("insert into VoteSet(VoteLimit,Candidate) values('{0}','{1}')", comboBox1.Text,comboBox2.Text);
            MessageBox.Show(strsql);
            command = new SqlCommand(strsql, mycon);
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("Save successful");
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int minute = totalSecond / 60;
            int second = totalSecond % 60;
            String str = minute.ToString() + ":" + second.ToString() + ":" + tenthSecond.ToString();
           textBox1.Text = str;
            tenthSecond--;
            if (tenthSecond == -1)
            {
                tenthSecond = 9;
                totalSecond--;
                if (totalSecond == -1)
                {
                    timer1.Enabled = false;
                    //timer3.Enabled = false;
                    textBox1.Text = "TimeOver！";
                   textBox1.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
        }

       

        

        private void VotingSetting_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

            this.timer1.Stop();
           
        }
    }
}
