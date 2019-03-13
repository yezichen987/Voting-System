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
            comboBox1.Items.Add(new Item("10px", 10));
            comboBox1.Items.Add(new Item("20px", 20));
            comboBox1.Items.Add(new Item("25px", 25));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
        public CandidateIntroduction1(byte[] imagebytes)
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        public CandidateIntroduction1(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Hide();
            candidateInformation.ShowDialog(this);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            label5.Font = new Font("Arial", itm.size);
            button1.Font = new Font("Arial", itm.size);
         
        }

        private void CandidateIntroduction_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("select Image from CandidateImage where CandidateImgId='1'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MemoryStream buf = new MemoryStream((byte[])reader[0]);
            Image image = Image.FromStream(buf, true);
            pictureBox1.Image = image;
            label1.Text = DateTime.Now.ToString();
        }
       
 
       

        }
    }

