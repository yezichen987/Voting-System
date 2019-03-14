using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Homepage1 : Form
    {
       
        public Homepage1()
        {
            InitializeComponent();
        
            comboBox1.Items.Add(new Item("10px", 10));
            comboBox1.Items.Add(new Item("20px", 20));
            comboBox1.Items.Add(new Item("25px", 25));
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

        private void button1_Click(object sender, EventArgs e)
        {
            StartVoting startVoting = new StartVoting();
            this.Hide();
            startVoting.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Hide();
            candidateInformation.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Close();
            candidateInformation.ShowDialog(this);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
            pictureBox1.Image = AnnoucementManagement.pic.Image;
            pictureBox1.SizeMode = AnnoucementManagement.pic.SizeMode;
            pictureBox1.Size = pictureBox1.Size;
        }

        private void registeredLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)comboBox1.SelectedItem;

            label2.Font = new Font("Arial", itm.size);
            button1.Font = new Font("Arial", itm.size);
            button2.Font = new Font("Arial", itm.size);
            button3.Font = new Font("Arial", itm.size);
            TimeLabel.Font = new Font("Arial", itm.size);
            HomePageLabel.Font = new Font("Arial", itm.size);
            
            registeredLabel.Font = new Font("Arial", itm.size);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
