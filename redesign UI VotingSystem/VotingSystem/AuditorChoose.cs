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
            // TODO: 这行代码将数据加载到表“votingDataSet.Voting”中。您可以根据需要移动或删除它。
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);

        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
           
            Public.VoteName.ChooseVote = VoteNamecomboBox.Text;

            Voting_Data_Graphic VDG = new Voting_Data_Graphic();
            this.Hide();
            VDG.ShowDialog(this);
        }
    }
}
