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
using System.IO;

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
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CandidateIntroduction_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("select Image from CandidateImage where Id='1'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MemoryStream buf = new MemoryStream((byte[])reader[0]);
            Image image = Image.FromStream(buf, true);
            pictureBox1.Image = image;

        }
        // public void PicboxShow(PictureBox pictureBox2)
        //{
        //    byte[] imagebytes = null;

        //    //打开数据库

        //    SqlConnection con = new SqlConnection("server=.;database=PointSchool;User =sa; pwd =123");

        //    con.Open();

        //    SqlCommand com = new SqlCommand("select top 1* from CandidateImage_Image", con);

        //    SqlDataReader dr = com.ExecuteReader();

        //    while (dr.Read())
        //    {

        //        imagebytes = (byte[])dr.GetValue(1);

        //    }

        //    dr.Close();

        //    com.Clone();

        //    con.Close();

        //    CandidateIntroduction ms = new CandidateIntroduction(imagebytes);

        //    Bitmap bmpt = new Bitmap(ms.ToString());

        //    pictureBox2.Image = bmpt;
        //    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        //}

 
       

        }
    }

