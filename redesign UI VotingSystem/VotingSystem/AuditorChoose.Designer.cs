﻿namespace VotingSystem
{
    partial class AuditorChoose
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.VoteNamecomboBox = new System.Windows.Forms.ComboBox();
            this.votingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingDataSet = new VotingSystem.VotingDataSet();
            this.Enter = new System.Windows.Forms.Button();
            this.votingTableAdapter = new VotingSystem.VotingDataSetTableAdapters.VotingTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voting: ";
            // 
            // VoteNamecomboBox
            // 
            this.VoteNamecomboBox.DataSource = this.votingBindingSource;
            this.VoteNamecomboBox.DisplayMember = "VoteName";
            this.VoteNamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoteNamecomboBox.FormattingEnabled = true;
            this.VoteNamecomboBox.Location = new System.Drawing.Point(101, 67);
            this.VoteNamecomboBox.Name = "VoteNamecomboBox";
            this.VoteNamecomboBox.Size = new System.Drawing.Size(121, 20);
            this.VoteNamecomboBox.TabIndex = 1;
            // 
            // votingBindingSource
            // 
            this.votingBindingSource.DataMember = "Voting";
            this.votingBindingSource.DataSource = this.votingDataSet;
            // 
            // votingDataSet
            // 
            this.votingDataSet.DataSetName = "VotingDataSet";
            this.votingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(71, 116);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // votingTableAdapter
            // 
            this.votingTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Voting";
            // 
            // AuditorChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.VoteNamecomboBox);
            this.Controls.Add(this.label1);
            this.Name = "AuditorChoose";
            this.Text = "AuditorChoose";
            this.Load += new System.EventHandler(this.AuditorChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoteNamecomboBox;
        private System.Windows.Forms.Button Enter;
        private VotingDataSet votingDataSet;
        private System.Windows.Forms.BindingSource votingBindingSource;
        private VotingDataSetTableAdapters.VotingTableAdapter votingTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}