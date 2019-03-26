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
            string msg = string.Format("Auditor:{0}", LoginInfo.CurrentUser.UserName);
            label9.Text = msg;
        }
        string strcon, strsql;
        SqlConnection mycon;//open the database connection
        SqlCommand command;//Specify the SQL statement to execute
        DataSet DS;//rename dataset to DS
        SqlDataAdapter DA;
        public string str;
        string key;

        private bool DBConnect()
        {
            try
            {
                //strcon = "Data Source=DESKTOP-6UGITVT;Initial Catalog=Voting;Integrated Security=True";
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);//Specify the SQL statement to execute
                mycon.Open();//open the connection
                MessageBox.Show("DB Connect is good");
                return true;//Displayed when the database connection is successful
            }
            catch
            {
                MessageBox.Show("DB Connect is not connect");

                return false;//Displayed when the database connection is fail
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            
            Series Strength = new Series("Number");
          
            Strength.ChartType = SeriesChartType.Column;
        
            Strength.Points.AddXY(label1.Text, textBox1.Text);//Get the text in the text box
            Strength.Points.AddXY(label2.Text, textBox2.Text);//Get the text in the text box
            Strength.Points.AddXY(label3.Text, textBox3.Text);//Get the text in the text box
            Strength.Points.AddXY(label4.Text, textBox4.Text);//Get the text in the text box
            Strength.Points.AddXY(label5.Text, textBox5.Text);//Get the text in the text box
            Strength.Points.AddXY(label6.Text, textBox6.Text);//Get the text in the text box

            chart1.Series.Add(Strength);
            chart2.Series[0]["PieLabelStyle"] = "Outside";
            chart2.Series[0]["PieLineColor"] = "Black";
            List<String> XData = new List<string>() { label1.Text, label2.Text, label3.Text, label4.Text, label5.Text, label6.Text };
            List<String> YData = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            chart2.Series[0].Points.DataBindXY(XData, YData);
            //chart2.Series[0].Label = "#VALX;#PERCENT{P2}";
        }

        private void Voting_Data_Graphic_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            DBConnect();//connect to the database
            showDataGrid();
            DGV1.RowHeadersVisible = false;
        }
        private void showDataGrid()
        {
            strsql = string.Format("select * from Candidate Where VoteName = '{0}'" , Public.VoteName.ChooseVote );
           
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            command.ExecuteScalar();//Loop the entire object
            DS = new DataSet();
            DA = new SqlDataAdapter(command);
            DA.Fill(DS, "Candidate");
            DGV1.DataSource = DS.Tables["Candidate"];
        }
        private void showDataGrid(string sqlco)
        {
            strsql = sqlco;
            command = new SqlCommand(strsql, mycon);//Specify the SQL statement to execute
            MessageBox.Show(strsql);
            command.ExecuteScalar();//Loop the entire object
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuditorChoose auditorChoose = new AuditorChoose();
            this.Hide();
            auditorChoose.ShowDialog(this);//Interface conversion function
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
