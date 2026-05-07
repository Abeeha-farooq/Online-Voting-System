namespace DB__PROJECT
{
    partial class VoterDashboard
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
            this.btnViewElections = new System.Windows.Forms.Button();
            this.btnCastVote = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewElections
            // 
            this.btnViewElections.Location = new System.Drawing.Point(331, 107);
            this.btnViewElections.Name = "btnViewElections";
            this.btnViewElections.Size = new System.Drawing.Size(300, 60);
            this.btnViewElections.TabIndex = 5;
            this.btnViewElections.Text = "View Elections";
            this.btnViewElections.UseVisualStyleBackColor = true;
            this.btnViewElections.Click += new System.EventHandler(this.btnViewElections_Click);
            // 
            // btnCastVote
            // 
            this.btnCastVote.Location = new System.Drawing.Point(331, 197);
            this.btnCastVote.Name = "btnCastVote";
            this.btnCastVote.Size = new System.Drawing.Size(300, 60);
            this.btnCastVote.TabIndex = 6;
            this.btnCastVote.Text = "Cast Vote";
            this.btnCastVote.UseVisualStyleBackColor = true;
            this.btnCastVote.Click += new System.EventHandler(this.btnCastVote_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(416, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(138, 55);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.Location = new System.Drawing.Point(331, 293);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(300, 60);
            this.btnViewResults.TabIndex = 8;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = true;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(380, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Voter Dashboard";
            // 
            // VoterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCastVote);
            this.Controls.Add(this.btnViewElections);
            this.Name = "VoterDashboard";
            this.Text = "VoterFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewElections;
        private System.Windows.Forms.Button btnCastVote;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Label label1;
    }
}