namespace VotingSystem
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginlinkLabel = new System.Windows.Forms.LinkLabel();
            this.registeredLabel = new System.Windows.Forms.LinkLabel();
            this.HomePageLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartVotingbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontsizecomboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginInfolabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginlinkLabel);
            this.panel1.Controls.Add(this.registeredLabel);
            this.panel1.Controls.Add(this.HomePageLabel);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginlinkLabel
            // 
            this.LoginlinkLabel.AutoSize = true;
            this.LoginlinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginlinkLabel.Location = new System.Drawing.Point(806, 18);
            this.LoginlinkLabel.Name = "LoginlinkLabel";
            this.LoginlinkLabel.Size = new System.Drawing.Size(37, 19);
            this.LoginlinkLabel.TabIndex = 3;
            this.LoginlinkLabel.TabStop = true;
            this.LoginlinkLabel.Text = "login";
            this.LoginlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registeredLabel
            // 
            this.registeredLabel.AutoSize = true;
            this.registeredLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredLabel.Location = new System.Drawing.Point(636, 18);
            this.registeredLabel.Name = "registeredLabel";
            this.registeredLabel.Size = new System.Drawing.Size(68, 19);
            this.registeredLabel.TabIndex = 2;
            this.registeredLabel.TabStop = true;
            this.registeredLabel.Text = "registered";
            this.registeredLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registeredLabel_LinkClicked);
            // 
            // HomePageLabel
            // 
            this.HomePageLabel.AutoSize = true;
            this.HomePageLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLabel.Location = new System.Drawing.Point(395, 18);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(106, 23);
            this.HomePageLabel.TabIndex = 1;
            this.HomePageLabel.Text = "Home Page";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(45, 18);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(34, 19);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "time";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font Size";
            // 
            // StartVotingbutton
            // 
            this.StartVotingbutton.AutoSize = true;
            this.StartVotingbutton.Location = new System.Drawing.Point(34, 424);
            this.StartVotingbutton.Name = "StartVotingbutton";
            this.StartVotingbutton.Size = new System.Drawing.Size(200, 85);
            this.StartVotingbutton.TabIndex = 6;
            this.StartVotingbutton.Text = "Start Voting";
            this.StartVotingbutton.UseVisualStyleBackColor = true;
            this.StartVotingbutton.Click += new System.EventHandler(this.StartVotingbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 85);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 85);
            this.button3.TabIndex = 8;
            this.button3.Text = "View Voting Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fontsizecomboBox
            // 
            this.fontsizecomboBox.FormattingEnabled = true;
            this.fontsizecomboBox.Location = new System.Drawing.Point(823, 76);
            this.fontsizecomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fontsizecomboBox.Name = "fontsizecomboBox";
            this.fontsizecomboBox.Size = new System.Drawing.Size(92, 20);
            this.fontsizecomboBox.TabIndex = 10;
            this.fontsizecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.vote1;
            this.pictureBox1.Location = new System.Drawing.Point(195, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginInfolabel
            // 
            this.LoginInfolabel.AutoSize = true;
            this.LoginInfolabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfolabel.Location = new System.Drawing.Point(32, 79);
            this.LoginInfolabel.Name = "LoginInfolabel";
            this.LoginInfolabel.Size = new System.Drawing.Size(38, 15);
            this.LoginInfolabel.TabIndex = 11;
            this.LoginInfolabel.Text = "label1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 553);
            this.Controls.Add(this.LoginInfolabel);
            this.Controls.Add(this.fontsizecomboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StartVotingbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.RightToLeftLayout = true;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label HomePageLabel;
        private System.Windows.Forms.LinkLabel LoginlinkLabel;
        private System.Windows.Forms.LinkLabel registeredLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartVotingbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox fontsizecomboBox;
        private System.Windows.Forms.Label LoginInfolabel;
    }
}

