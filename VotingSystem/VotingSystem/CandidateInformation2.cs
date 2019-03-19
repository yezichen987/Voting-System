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
using System.Windows.Forms.DataVisualization.Charting;

namespace VotingSystem
{
    public partial class CandidateInformation2 : Form
    {
        public CandidateInformation2()
        {
            InitializeComponent();
        }

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet DS;
        SqlDataAdapter DA;
        public string str;
        string key;

        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);
                mycon.Open();
                //MessageBox.Show("DB Connect is good");
                return true;
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
            }
        }

        private void showDataGrid()
        {
            strsql = string.Format("select Name,VoteName from Candidate Where VoteName = '{0}'", comboBox1.Text);

            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }
        private void showDataGrid(string sqlco)
        {
            strsql = sqlco;
            command = new SqlCommand(strsql, mycon);
            MessageBox.Show(strsql);
            command.ExecuteScalar();
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }

        private void CandidateInformation2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“votingDataSet.Voting”中。您可以根据需要移动或删除它。
            this.votingTableAdapter.Fill(this.votingDataSet.Voting);

            DBConnect();
            

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellvalue = DGV1.SelectedCells[0].Value.ToString();
            textBox1.Text = cellvalue;
        }

        private void Getbutton_Click(object sender, EventArgs e)
        {
            Public.CandidateName.ChooseCandidate = textBox1.Text;
            CandidateIntroduction1 CINTRO = new CandidateIntroduction1();
            this.Hide();
            CINTRO.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDataGrid();

            DGV1.RowHeadersVisible = false;
        }


    }
}
