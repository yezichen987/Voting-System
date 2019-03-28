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
    public partial class AuditorChoose : Form
    {
        public AuditorChoose()
        {
            InitializeComponent();
        }

        private void AuditorChoose_Load(object sender, EventArgs e)
        {
            //get votingdata in the votingDataSet
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);

        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
           
            Public.VoteName.ChooseVote = VoteNamecomboBox.Text;

            Voting_Data_Graphic VDG = new Voting_Data_Graphic();
            this.Hide();
            VDG.ShowDialog(this);
            //Interface conversion function
        }
    }
}
