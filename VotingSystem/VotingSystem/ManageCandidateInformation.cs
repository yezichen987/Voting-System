using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
namespace VotingSystem
{
    public partial class ManageCandidateInformation : Form
    {
        public ManageCandidateInformation()
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        private bool DBConnect()
        {
            try
            {
                strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";

                mycon = new SqlConnection(strcon);
                mycon.Open();
                MessageBox.Show("DB Connect is good");
                return true;
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;
            }
        }
        private bool check()
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Select();
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Select();
                return false;
            }
            return true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageCandidateInformation_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void ManageCandidateInformation_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            string file = files[0];
            if (!file.ToLower().EndsWith(".png") && !file.ToLower().EndsWith(".jpg"))
            {
                MessageBox.Show("Need Picture!");
                return;
            }
           
            pictureBox1.Load(file);

        }

        private void ManageCandidateInformation_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
           
        }
        public bool ExecuteNone(string[] sql)
        {
            bool result;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True");
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = tran;

            try
            {
                for (int i = 0; i < sql.Length; i++)
                {
                    if (sql[i] == null || sql[i] == "")
                    {
                        continue;
                    }
                    cmd.CommandText = sql[i];
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
                result = true;

            }

            catch (System.Exception)
            {
                tran.Rollback();
                result = false;
            }
            conn.Close();

            return result;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Load(openFileDialog1.FileName);
                string extension = Path.GetExtension(openFileDialog1.FileName);
                 
                string[] str = new string[] { ".gif", ".jpge", ".jpg", ".png" };
                if (!str.Contains(extension))
                {
                    MessageBox.Show("Only'gif,jpge,jpg 'can be upload！");
                }
                else
                {
                    
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    if (fileInfo.Length > 409060)
                    {
                        MessageBox.Show("the size of picture need to < 400K");
                    }
                    else
                    {
                        //Path
                        string image = openFileDialog1.FileName;
                        //  XXX.jpg
                        string picpath = openFileDialog1.SafeFileName;
                       //File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Image\\" + picpath);
                    }
                }
            }

        }
      



        private void button2_Click(object sender, EventArgs e)
        {
           
            DBConnect();
            strsql = string.Format("insert into Candidate(Name,information) values('{0}','{1}')", textBox1.Text,textBox2.Text);
            MessageBox.Show(strsql);
            command = new SqlCommand(strsql, mycon);
            try
            {
                command.ExecuteScalar();
                MessageBox.Show("upload successful");
               
            }
            catch
            { 
                MessageBox.Show("upload failed");
            }
            finally
            {
                mycon.Close();
            }
        

        }
        public void InageShow(PictureBox PB)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = " 请选择客户端longin的图片";
            openfile.Filter = "Login图片 (*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                try
                {
                    Bitmap bmp = new Bitmap(openfile.FileName);
                    pictureBox1.Image = bmp;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    //字面是对当前图片进行了二进制转换
                    MemoryStream ms = new MemoryStream();
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    byte[] arr = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(arr, 0, (int)ms.Length);
                    ms.Close();
                    //直接返这个值放到数据就行了
                    string ee = Convert.ToBase64String(arr);
                }
                catch { }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //获取用户打开的路径然转换成二进制存入数据库

          
                OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                string filePath = ofd.FileName;//图片路径
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] imageBytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流

                string strSql = string.Format("insert into Candidate(Image)Values(@Image)");
                int count = Write(strSql, imageBytes);

                if (count > 0)
                {
                    MessageBox.Show("Successful！");
                   
                }
                else
                {
                    MessageBox.Show("Fail！");
                }
            }


        }
        private int Write(string strSql, byte[] imageBytes)
        {
            string connStr = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlParameter sqlParameter = new SqlParameter("@image", SqlDbType.Image);
                        sqlParameter.Value = imageBytes;
                        cmd.Parameters.Add(sqlParameter);
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }
            }
        }


    }
}
