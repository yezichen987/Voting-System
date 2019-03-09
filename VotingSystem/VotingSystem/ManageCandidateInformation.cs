using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VotingSystem
{
    public partial class ManageCandidateInformation : Form
    {
        public ManageCandidateInformation()
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
            if (textBox1.Text.Length == 0)
            {
                textBox1.Select();
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Select();
                return false;
            }
            return true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageCandidateInformation_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void ManageCandidateInformation_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            string file = files[0];
            if (!file.ToLower().EndsWith(".png") && !file.ToLower().EndsWith(".jpg"))
            {
                MessageBox.Show("Need Picture!");
                return;
            }
           
            pictureBox1.Load(file);

        }

        private void ManageCandidateInformation_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            if (textBox1.Text == null)
            {
                button2.Enabled = false;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Load(openFileDialog1.FileName);
                string extension = Path.GetExtension(openFileDialog1.FileName);
                 
                string[] str = new string[] { ".gif", ".jpge", ".jpg", ".png" };
                if (!str.Contains(extension))
                {
                    MessageBox.Show("Only'gif,jpge,jpg 'can be upload！");
                }
                else
                {
                    
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    if (fileInfo.Length > 40960)
                    {
                        MessageBox.Show("the size of picture need to < 40K");
                    }
                    else
                    {
                        //Path
                        string image = openFileDialog1.FileName;
                        //  XXX.jpg
                        string picpath = openFileDialog1.SafeFileName;
                       //File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Image\\" + picpath);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DBConnect();
            strsql = string.Format("insert into Candidate(Name,information) values('{0}','{1}')", textBox1.Text,textBox2.Text);
            MessageBox.Show(strsql);
            command = new SqlCommand(strsql, mycon);
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("upload successful");
               
            }
            catch
            {
                MessageBox.Show("upload failed");
            }
            finally
            {
                mycon.Close();
            }
        }
    }
}
