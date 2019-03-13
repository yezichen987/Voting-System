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
    public partial class CandidateIntroduction2 : Form
    {
        public CandidateIntroduction2()
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
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        public CandidateIntroduction2(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Hide();
            candidateInformation.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item itm = (Item)comboBox1.SelectedItem;
            label1.Font = new Font("Arial", itm.size);
            label2.Font = new Font("Arial", itm.size);
            label3.Font = new Font("Arial", itm.size);
            label4.Font = new Font("Arial", itm.size);
            label5.Font = new Font("Arial", itm.size);
            button1.Font = new Font("Arial", itm.size);
        }

        private void CandidateIntroduction2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("select Image from CandidateImage where CandidateImgId='2'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MemoryStream buf = new MemoryStream((byte[])reader[0]);
            Image image = Image.FromStream(buf, true);
            pictureBox1.Image = image;
            label1.Text = DateTime.Now.ToString();
        }
    }
}
