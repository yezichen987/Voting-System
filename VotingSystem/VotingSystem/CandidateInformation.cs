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
    public partial class CandidateInformation : Form
    {
        public CandidateInformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction1 candidateIntroduction = new CandidateIntroduction1();
            this.Hide();
            candidateIntroduction.ShowDialog(this);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction2 candidateIntroduction2 = new CandidateIntroduction2();
            this.Hide();
            candidateIntroduction2.ShowDialog(this);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction3 candidateIntroduction3 = new CandidateIntroduction3();
            this.Hide();
            candidateIntroduction3.ShowDialog(this);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction4 candidateIntroduction4 = new CandidateIntroduction4();
            this.Hide();
            candidateIntroduction4.ShowDialog(this);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction5 candidateIntroduction5 = new CandidateIntroduction5();
            this.Hide();
            candidateIntroduction5.ShowDialog(this);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CandidateIntroduction6 candidateIntroduction6 = new CandidateIntroduction6();
            this.Hide();
            candidateIntroduction6.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }
    }
}
