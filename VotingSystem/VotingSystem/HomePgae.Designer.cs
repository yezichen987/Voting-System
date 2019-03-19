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
            this.GetInforButton = new System.Windows.Forms.Button();
            this.Databutton = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 81);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginlinkLabel
            // 
            this.LoginlinkLabel.AutoSize = true;
            this.LoginlinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginlinkLabel.Location = new System.Drawing.Point(1075, 22);
            this.LoginlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginlinkLabel.Name = "LoginlinkLabel";
            this.LoginlinkLabel.Size = new System.Drawing.Size(50, 22);
            this.LoginlinkLabel.TabIndex = 3;
            this.LoginlinkLabel.TabStop = true;
            this.LoginlinkLabel.Text = "login";
            this.LoginlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registeredLabel
            // 
            this.registeredLabel.AutoSize = true;
            this.registeredLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredLabel.Location = new System.Drawing.Point(848, 22);
            this.registeredLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registeredLabel.Name = "registeredLabel";
            this.registeredLabel.Size = new System.Drawing.Size(89, 22);
            this.registeredLabel.TabIndex = 2;
            this.registeredLabel.TabStop = true;
            this.registeredLabel.Text = "registered";
            this.registeredLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registeredLabel_LinkClicked);
            // 
            // HomePageLabel
            // 
            this.HomePageLabel.AutoSize = true;
            this.HomePageLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLabel.Location = new System.Drawing.Point(527, 22);
            this.HomePageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(137, 31);
            this.HomePageLabel.TabIndex = 1;
            this.HomePageLabel.Text = "Home Page";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(60, 22);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(44, 22);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "time";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(920, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font Size";
            // 
            // StartVotingbutton
            // 
            this.StartVotingbutton.AutoSize = true;
            this.StartVotingbutton.Location = new System.Drawing.Point(45, 530);
            this.StartVotingbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartVotingbutton.Name = "StartVotingbutton";
            this.StartVotingbutton.Size = new System.Drawing.Size(267, 106);
            this.StartVotingbutton.TabIndex = 6;
            this.StartVotingbutton.Text = "Start Voting";
            this.StartVotingbutton.UseVisualStyleBackColor = true;
            this.StartVotingbutton.Click += new System.EventHandler(this.StartVotingbutton_Click);
            // 
            // GetInforButton
            // 
            this.GetInforButton.Location = new System.Drawing.Point(471, 530);
            this.GetInforButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetInforButton.Name = "GetInforButton";
            this.GetInforButton.Size = new System.Drawing.Size(283, 106);
            this.GetInforButton.TabIndex = 7;
            this.GetInforButton.Text = "Get Information";
            this.GetInforButton.UseVisualStyleBackColor = true;
            this.GetInforButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Databutton
            // 
            this.Databutton.Location = new System.Drawing.Point(903, 530);
            this.Databutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Databutton.Name = "Databutton";
            this.Databutton.Size = new System.Drawing.Size(248, 106);
            this.Databutton.TabIndex = 8;
            this.Databutton.Text = "View Voting Data";
            this.Databutton.UseVisualStyleBackColor = true;
            this.Databutton.Click += new System.EventHandler(this.button3_Click);
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
            this.fontsizecomboBox.Location = new System.Drawing.Point(1097, 95);
            this.fontsizecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fontsizecomboBox.Name = "fontsizecomboBox";
            this.fontsizecomboBox.Size = new System.Drawing.Size(121, 23);
            this.fontsizecomboBox.TabIndex = 10;
            this.fontsizecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.vote1;
            this.pictureBox1.Location = new System.Drawing.Point(260, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginInfolabel
            // 
            this.LoginInfolabel.AutoSize = true;
            this.LoginInfolabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfolabel.Location = new System.Drawing.Point(43, 99);
            this.LoginInfolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginInfolabel.Name = "LoginInfolabel";
            this.LoginInfolabel.Size = new System.Drawing.Size(51, 19);
            this.LoginInfolabel.TabIndex = 11;
            this.LoginInfolabel.Text = "label1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 691);
            this.Controls.Add(this.LoginInfolabel);
            this.Controls.Add(this.fontsizecomboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Databutton);
            this.Controls.Add(this.GetInforButton);
            this.Controls.Add(this.StartVotingbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button GetInforButton;
        private System.Windows.Forms.Button Databutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox fontsizecomboBox;
        private System.Windows.Forms.Label LoginInfolabel;
    }
}

