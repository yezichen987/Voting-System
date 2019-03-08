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
    public partial class Voting_Data_Graphic : Form
    {
        public Voting_Data_Graphic()
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
                strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";

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
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            //new 一个叫做【Strength】的系列
            Series Strength = new Series("Number");
            //设置chart的类型，这里为柱状图
            Strength.ChartType = SeriesChartType.Column;
            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            Strength.Points.AddXY(label1.Text, textBox1.Text);
            Strength.Points.AddXY(label2.Text, textBox2.Text);
            Strength.Points.AddXY(label3.Text, textBox3.Text);
            Strength.Points.AddXY(label4.Text, textBox4.Text);
            Strength.Points.AddXY(label5.Text, textBox5.Text);
            Strength.Points.AddXY(label6.Text, textBox6.Text);
            //把series添加到chart上
            chart1.Series.Add(Strength);

        }

        private void Voting_Data_Graphic_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            DGV1.RowHeadersVisible = false;
        }
        private void showDataGrid()
        {
            strsql = "select * from Candidate";
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
        private void update_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            int count = DS.Tables["Candidate"].Rows.Count;
            mycon.Close();
        }
        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            key = DGV1.CurrentRow.Cells[1].Value.ToString();
            label1.Text = DGV1.Rows[0].Cells[1].Value.ToString();
            label2.Text = DGV1.Rows[1].Cells[1].Value.ToString();
            label3.Text = DGV1.Rows[2].Cells[1].Value.ToString();
            label4.Text = DGV1.Rows[3].Cells[1].Value.ToString();
            label5.Text = DGV1.Rows[4].Cells[1].Value.ToString();
            label6.Text = DGV1.Rows[5].Cells[1].Value.ToString();
            textBox1.Text = DGV1.Rows[0].Cells[4].Value.ToString();
            textBox2.Text = DGV1.Rows[1].Cells[4].Value.ToString();
            textBox3.Text = DGV1.Rows[2].Cells[4].Value.ToString();
            textBox4.Text = DGV1.Rows[3].Cells[4].Value.ToString();
            textBox5.Text = DGV1.Rows[4].Cells[4].Value.ToString();
            textBox6.Text = DGV1.Rows[5].Cells[4].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
