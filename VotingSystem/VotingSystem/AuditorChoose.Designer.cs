namespace VotingSystem
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
            this.ChooseButton = new System.Windows.Forms.Button();
            this.votingDataSet = new VotingSystem.VotingDataSet();
            this.votingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingTableAdapter = new VotingSystem.VotingDataSetTableAdapters.VotingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // VoteNamecomboBox
            // 
            this.VoteNamecomboBox.DataSource = this.votingBindingSource;
            this.VoteNamecomboBox.DisplayMember = "VoteName";
            this.VoteNamecomboBox.FormattingEnabled = true;
            this.VoteNamecomboBox.Location = new System.Drawing.Point(101, 67);
            this.VoteNamecomboBox.Name = "VoteNamecomboBox";
            this.VoteNamecomboBox.Size = new System.Drawing.Size(121, 20);
            this.VoteNamecomboBox.TabIndex = 1;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(80, 117);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Enter";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // votingDataSet
            // 
            this.votingDataSet.DataSetName = "VotingDataSet";
            this.votingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votingBindingSource
            // 
            this.votingBindingSource.DataMember = "Voting";
            this.votingBindingSource.DataSource = this.votingDataSet;
            // 
            // votingTableAdapter
            // 
            this.votingTableAdapter.ClearBeforeFill = true;
            // 
            // AuditorChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.VoteNamecomboBox);
            this.Controls.Add(this.label1);
            this.Name = "AuditorChoose";
            this.Text = "AuditorChoose";
            this.Load += new System.EventHandler(this.AuditorChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoteNamecomboBox;
        private System.Windows.Forms.Button ChooseButton;
        private VotingDataSet votingDataSet;
        private System.Windows.Forms.BindingSource votingBindingSource;
        private VotingDataSetTableAdapters.VotingTableAdapter votingTableAdapter;
    }
}