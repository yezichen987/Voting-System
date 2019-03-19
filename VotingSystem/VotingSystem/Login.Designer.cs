namespace VotingSystem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BacklinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminradioButton = new System.Windows.Forms.RadioButton();
            this.AuditorradioButton = new System.Windows.Forms.RadioButton();
            this.VoterradioButton = new System.Windows.Forms.RadioButton();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BacklinkLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 54);
            this.panel1.TabIndex = 0;
            // 
            // BacklinkLabel
            // 
            this.BacklinkLabel.AutoSize = true;
            this.BacklinkLabel.Location = new System.Drawing.Point(416, 24);
            this.BacklinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BacklinkLabel.Name = "BacklinkLabel";
            this.BacklinkLabel.Size = new System.Drawing.Size(39, 15);
            this.BacklinkLabel.TabIndex = 2;
            this.BacklinkLabel.TabStop = true;
            this.BacklinkLabel.Text = "back";
            this.BacklinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BacklinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(233, 148);
            this.UserNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(195, 25);
            this.UserNametextBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(233, 258);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(195, 25);
            this.PasswordBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(39, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // AdminradioButton
            // 
            this.AdminradioButton.AutoSize = true;
            this.AdminradioButton.Location = new System.Drawing.Point(233, 352);
            this.AdminradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminradioButton.Name = "AdminradioButton";
            this.AdminradioButton.Size = new System.Drawing.Size(68, 19);
            this.AdminradioButton.TabIndex = 9;
            this.AdminradioButton.TabStop = true;
            this.AdminradioButton.Text = "Admin";
            this.AdminradioButton.UseVisualStyleBackColor = true;
            // 
            // AuditorradioButton
            // 
            this.AuditorradioButton.AutoSize = true;
            this.AuditorradioButton.Location = new System.Drawing.Point(233, 409);
            this.AuditorradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuditorradioButton.Name = "AuditorradioButton";
            this.AuditorradioButton.Size = new System.Drawing.Size(84, 19);
            this.AuditorradioButton.TabIndex = 10;
            this.AuditorradioButton.TabStop = true;
            this.AuditorradioButton.Text = "Auditor";
            this.AuditorradioButton.UseVisualStyleBackColor = true;
            // 
            // VoterradioButton
            // 
            this.VoterradioButton.AutoSize = true;
            this.VoterradioButton.Location = new System.Drawing.Point(359, 352);
            this.VoterradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VoterradioButton.Name = "VoterradioButton";
            this.VoterradioButton.Size = new System.Drawing.Size(68, 19);
            this.VoterradioButton.TabIndex = 11;
            this.VoterradioButton.TabStop = true;
            this.VoterradioButton.Text = "Voter";
            this.VoterradioButton.UseVisualStyleBackColor = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(71, 479);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(100, 29);
            this.Loginbutton.TabIndex = 12;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(301, 479);
            this.Registerbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(100, 29);
            this.Registerbutton.TabIndex = 13;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 576);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.VoterradioButton);
            this.Controls.Add(this.AuditorradioButton);
            this.Controls.Add(this.AdminradioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel BacklinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton AdminradioButton;
        private System.Windows.Forms.RadioButton AuditorradioButton;
        private System.Windows.Forms.RadioButton VoterradioButton;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Registerbutton;
    }
}