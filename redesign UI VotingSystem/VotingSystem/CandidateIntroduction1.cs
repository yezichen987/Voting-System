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
using System.IO;

namespace VotingSystem
{
    public partial class CandidateIntroduction1 : Form
    {
        public CandidateIntroduction1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Item("10px", 10));//Change text font
            comboBox1.Items.Add(new Item("20px", 20));//Change text font
            comboBox1.Items.Add(new Item("25px", 25));//Change text font
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        string strcon, strsql;
        SqlConnection mycon;//open the database connection
        SqlCommand command;//Specify the SQL statement to execute
        DataSet DS;
        SqlDataAdapter DA;
        public string str;
        string key;
        //connect to database
        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);
                mycon.Open();
                //MessageBox.Show("DB Connect is good");
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

        private class Item
        {
            public string sizeName;
            public int size;
            public Item(string name, int value)
            {
                sizeName = name; size = value;
            }
            public override string ToString()
            {
                return sizeName;
            }
        }
        //Fixed font size
        public CandidateIntroduction1(byte[] imagebytes)
        {
            InitializeComponent();
        }
       
        public CandidateIntroduction1(Image image)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateInformation2 candidateInformation = new CandidateInformation2();
            this.Hide();
            candidateInformation.ShowDialog(this);
            //Interface conversion function

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)comboBox1.SelectedItem;
            label1.Font = new Font("Arial", itm.size);
            label2.Font = new Font("Arial", itm.size);
            label3.Font = new Font("Arial", itm.size);
            label4.Font = new Font("Arial", itm.size);
           
            button1.Font = new Font("Arial", itm.size);
            //Font used for fixed text
        }

        private void CandidateIntroduction_Load(object sender, EventArgs e)
        {
            DBConnect();
            showInfo();
            timer1.Interval = 1000;
            timer1.Start();
            label3.Text = Public.CandidateName.ChooseCandidate;
            //SqlConnection conn = new SqlConnection(strcon);
            //(@"Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");
            //conn.Open();
            //showImage();
            //Connect to the database and display the tabular data

        }

        private void showInfo()
        {
            strsql = string.Format("select Information from Candidate Where Name = '{0}'", Public.CandidateName.ChooseCandidate);
            command = new SqlCommand(strsql, mycon);
            DA = new SqlDataAdapter(command);
            DS = new DataSet();
            DA.Fill(DS);
            String Info = DS.Tables[0].Rows[0]["Information"].ToString();
            label4.Text = "Information: " + Info;
            //connect to the database
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //display the datetime
        }

        //private void showImage()
        //{
        //    strsql = string.Format("select Image from Candidate where Name='{0}'", Public.CandidateName.ChooseCandidate);
        //    command = new SqlCommand(strsql, mycon);
        //    SqlDataReader reader = command.ExecuteReader();
        //    reader.Read();
        //    MemoryStream buf = new MemoryStream((byte[])reader[0]);
        //    Image image = Image.FromStream(buf, true);
        //    pictureBox1.Image = image;
        //    label1.Text = DateTime.Now.ToString();
        //}

       

        }
    }

