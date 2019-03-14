using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VotingSystem
{
    public partial class AnnoucementManagement : Form
    {
        public AnnoucementManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

        }
        public static PictureBox pic = new PictureBox();
        private void AnnoucementManagement_Load(object sender, EventArgs e)
        {
            pic.Image = pictureBox1.Image;
            pic.SizeMode = pictureBox1.SizeMode;
            pic.Size = pictureBox1.Size;
            this.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage1 homepage = new Homepage1();
            homepage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void AnnoucementManagement_DragDrop(object sender, DragEventArgs e)
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

        private void AnnoucementManagement_DragEnter(object sender, DragEventArgs e)
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
    }
}
