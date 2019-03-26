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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();

            string msg = string.Format("Admin:{0}", LoginInfo.CurrentUser.UserName);

            label3.Text = msg;
            //Information display

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageCandidateInformation MCI = new ManageCandidateInformation();
            this.Hide();
            MCI.ShowDialog(this);
            //Interface conversion function
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageVotingStatement MVS = new ManageVotingStatement();
            this.Hide();
            MVS.ShowDialog(this);
            //Interface conversion function
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VotingSetting voting = new VotingSetting();
            this.Hide();
            voting.ShowDialog(this);
            //Interface conversion function
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VotingControl VC = new VotingControl();
            this.Hide();
            VC.ShowDialog(this);
            //Interface conversion function
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
           // label1.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            timer1.Start();
            //Perform a time event every 1000 milliseconds
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //Get time and display
        }
    }
}
