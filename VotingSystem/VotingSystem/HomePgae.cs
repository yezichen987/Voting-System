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
    public partial class HomePage : Form
    {
        Image[] images = new Image[3];
        public HomePage()
        {

            InitializeComponent();
            images[0] = Properties.Resources.vote1;
            images[1] = Properties.Resources.vote2;
            images[2] = Properties.Resources.vote3;
            
            fontsizecomboBox.Items.Add(new Item("10px", 10));
            fontsizecomboBox.Items.Add(new Item("12px", 12));
            fontsizecomboBox.Items.Add(new Item("15px", 15));
            fontsizecomboBox.Items.Add(new Item("18px", 18));
            fontsizecomboBox.Items.Add(new Item("20px", 20));
            fontsizecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string msg = string.Format("Voter:{0}", LoginInfo.CurrentUser.UserName);
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
            if(LoginInfo.CurrentUser.UserName=="")
            {
                LoginlinkLabel.Text = "Login";
            }
            else
            {
                LoginlinkLabel.Text = "Voter Info";
            }

            if( LoginlinkLabel.Text == "Login" )
            {
                StartVotingbutton.Enabled = false;
            }
            else
            {
                StartVotingbutton.Enabled = true;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    StartVoting startVoting = new StartVoting();
        //    this.Hide();
        //    startVoting.ShowDialog(this);
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            ManageVotingStatement MVS = new ManageVotingStatement();
            this.Hide();
            MVS.ShowDialog(this);
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
            if(LoginInfo.CurrentUser.UserName=="")
            { 
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
            }
            else
            {
                VoterInformation VI = new VoterInformation();
                this.Hide();
                VI.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateInformation2 candidateInformation = new CandidateInformation2();
            this.Hide();
            candidateInformation.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)fontsizecomboBox.SelectedItem;
          
            label2.Font = new Font("Times New Roman", itm.size);
            StartVotingbutton.Font = new Font("Times New Roman", itm.size);
            GetInforButton.Font = new Font("Times New Roman", itm.size);
            Databutton.Font = new Font("Times New Roman", itm.size);
            TimeLabel.Font = new Font("Times New Roman", itm.size);
            HomePageLabel.Font = new Font("Times New Roman", itm.size);
            LoginlinkLabel.Font = new Font("Times New Roman", itm.size);
            registeredLabel.Font = new Font("Times New Roman", itm.size);
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartVotingbutton_Click(object sender, EventArgs e)
        {
            VotingChoose VC = new VotingChoose();
            this.Hide();
            VC.ShowDialog(this);
        }
    }
}
