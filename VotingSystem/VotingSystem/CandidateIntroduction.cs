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
namespace VotingSystem
{
    public partial class CandidateIntroduction : Form
    {
        public CandidateIntroduction()
        {
            InitializeComponent();
        }
        public CandidateIntroduction(byte[] imagebytes)
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        public CandidateIntroduction(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            this.Close();
            candidateInformation.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CandidateIntroduction_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            byte[] imagebytes = null;
            //打开数据库
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select Image from Candidate where Id=1", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                imagebytes = (byte[])dr.GetValue(1);
            }
            dr.Close();
            com.Clone();
            con.Close();
            CandidateIntroduction candidate = new CandidateIntroduction(imagebytes);
            Bitmap bmpt = new Bitmap(candidate.ToString());
            pictureBox1.Image = bmpt;

        }
    }
}
