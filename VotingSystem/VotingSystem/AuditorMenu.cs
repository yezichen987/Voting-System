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
    public partial class AuditorMenu : Form
    {
        public AuditorMenu()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Voting_Data_Graphic voting_Data_Graphic = new Voting_Data_Graphic();
            this.Close();
            voting_Data_Graphic.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Voting_Data_Check voting_Data_Check = new Voting_Data_Check();
            this.Close();
            voting_Data_Check.ShowDialog(this);
        }
    }
}
