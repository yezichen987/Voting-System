﻿using System;
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
    public partial class HomePage : Form
    {
        Image[] images = new Image[3];
        public HomePage()
        {

            InitializeComponent();
            images[0] = Properties.Resources.vote1;
            images[1] = Properties.Resources.vote2;
            images[2] = Properties.Resources.vote3;
            
            fontsizecomboBox.Items.Add(new Item("8px", 8));
            fontsizecomboBox.Items.Add(new Item("10px", 10));
            fontsizecomboBox.Items.Add(new Item("12px", 12));
            fontsizecomboBox.Items.Add(new Item("15px", 15));
            fontsizecomboBox.Items.Add(new Item("18px", 18));
            fontsizecomboBox.Items.Add(new Item("20px", 20));
            fontsizecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string msg = string.Format("帐号:{0}", LoginInfo.CurrentUser.UserName);
            LoginInfolabel.Text = msg;
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
        public HomePage(string str)
        {
            InitializeComponent();
            TimeLabel.Text = str;
        }
        private int i = 0;
        ImageList ilist = new ImageList();
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartVoting startVoting = new StartVoting();
            this.Hide();
            startVoting.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Close();
            candidateInformation.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = images[i];
            i++;
            if (i == 3) { i = 0; }
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void registeredLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Hide();
            candidateInformation.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)fontsizecomboBox.SelectedItem;
          
            label2.Font = new Font("Arial", itm.size);
            StartVotingbutton.Font = new Font("Arial", itm.size);
            button2.Font = new Font("Arial", itm.size);
            button3.Font = new Font("Arial", itm.size);
            TimeLabel.Font = new Font("Arial", itm.size);
            HomePageLabel.Font = new Font("Arial", itm.size);
            LoginlinkLabel.Font = new Font("Arial", itm.size);
            registeredLabel.Font = new Font("Arial", itm.size);
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartVotingbutton_Click(object sender, EventArgs e)
        {
            StartVoting startVoting = new StartVoting();
            this.Hide();
            startVoting.ShowDialog(this);
        }
    }
}
