namespace VotingSystem
{
    partial class VotingChoose
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
            this.VoteNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Choosebutton = new System.Windows.Forms.Button();
            this.votingDataSet = new VotingSystem.VotingDataSet();
            this.votingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingTableAdapter = new VotingSystem.VotingDataSetTableAdapters.VotingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VoteNamecomboBox
            // 
            this.VoteNamecomboBox.DataSource = this.votingBindingSource;
            this.VoteNamecomboBox.DisplayMember = "VoteName";
            this.VoteNamecomboBox.FormattingEnabled = true;
            this.VoteNamecomboBox.Location = new System.Drawing.Point(101, 82);
            this.VoteNamecomboBox.Name = "VoteNamecomboBox";
            this.VoteNamecomboBox.Size = new System.Drawing.Size(121, 20);
            this.VoteNamecomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Choosebutton
            // 
            this.Choosebutton.Location = new System.Drawing.Point(75, 126);
            this.Choosebutton.Name = "Choosebutton";
            this.Choosebutton.Size = new System.Drawing.Size(75, 23);
            this.Choosebutton.TabIndex = 2;
            this.Choosebutton.Text = "Enter";
            this.Choosebutton.UseVisualStyleBackColor = true;
            this.Choosebutton.Click += new System.EventHandler(this.Choosebutton_Click);
            // 
            // votingDataSet
            // 
            this.votingDataSet.DataSetName = "VotingDataSet";
            this.votingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votingDataSetBindingSource
            // 
            this.votingDataSetBindingSource.DataSource = this.votingDataSet;
            this.votingDataSetBindingSource.Position = 0;
            // 
            // votingBindingSource
            // 
            this.votingBindingSource.DataMember = "Voting";
            this.votingBindingSource.DataSource = this.votingDataSetBindingSource;
            // 
            // votingTableAdapter
            // 
            this.votingTableAdapter.ClearBeforeFill = true;
            // 
            // VotingChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.Choosebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoteNamecomboBox);
            this.Name = "VotingChoose";
            this.Text = "VotingChoose";
            this.Load += new System.EventHandler(this.VotingChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VoteNamecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Choosebutton;
        private System.Windows.Forms.BindingSource votingDataSetBindingSource;
        private VotingDataSet votingDataSet;
        private System.Windows.Forms.BindingSource votingBindingSource;
        private VotingDataSetTableAdapters.VotingTableAdapter votingTableAdapter;
    }
}