namespace DB__PROJECT
{
    partial class AdminDashboard
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
            this.btnParty = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElection = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTotalVotes = new System.Windows.Forms.Label();
            this.lblTotalVoters = new System.Windows.Forms.Label();
            this.lblTotalElections = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParty
            // 
            this.btnParty.Location = new System.Drawing.Point(128, 166);
            this.btnParty.Name = "btnParty";
            this.btnParty.Size = new System.Drawing.Size(348, 54);
            this.btnParty.TabIndex = 0;
            this.btnParty.Text = "Add Party";
            this.btnParty.UseVisualStyleBackColor = true;
            this.btnParty.Click += new System.EventHandler(this.btnParty_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(128, 245);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(348, 54);
            this.btnCandidates.TabIndex = 1;
            this.btnCandidates.Text = "Add Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(128, 324);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(348, 54);
            this.btnResults.TabIndex = 2;
            this.btnResults.Text = "View Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Dashboard";
            // 
            // btnElection
            // 
            this.btnElection.Location = new System.Drawing.Point(128, 87);
            this.btnElection.Name = "btnElection";
            this.btnElection.Size = new System.Drawing.Size(348, 54);
            this.btnElection.TabIndex = 4;
            this.btnElection.Text = "Add Election";
            this.btnElection.UseVisualStyleBackColor = true;
            this.btnElection.Click += new System.EventHandler(this.btnElection_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(229, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 49);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTotalVotes
            // 
            this.lblTotalVotes.AutoSize = true;
            this.lblTotalVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVotes.Location = new System.Drawing.Point(70, 34);
            this.lblTotalVotes.Name = "lblTotalVotes";
            this.lblTotalVotes.Size = new System.Drawing.Size(165, 32);
            this.lblTotalVotes.TabIndex = 6;
            this.lblTotalVotes.Text = "Total votes";
            this.lblTotalVotes.Click += new System.EventHandler(this.lblTotalVotes_Click);
            // 
            // lblTotalVoters
            // 
            this.lblTotalVoters.AutoSize = true;
            this.lblTotalVoters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVoters.Location = new System.Drawing.Point(70, 35);
            this.lblTotalVoters.Name = "lblTotalVoters";
            this.lblTotalVoters.Size = new System.Drawing.Size(175, 32);
            this.lblTotalVoters.TabIndex = 7;
            this.lblTotalVoters.Text = "Total voters";
            this.lblTotalVoters.Click += new System.EventHandler(this.lblTotalVoters_Click);
            // 
            // lblTotalElections
            // 
            this.lblTotalElections.AutoSize = true;
            this.lblTotalElections.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalElections.Location = new System.Drawing.Point(70, 33);
            this.lblTotalElections.Name = "lblTotalElections";
            this.lblTotalElections.Size = new System.Drawing.Size(223, 32);
            this.lblTotalElections.TabIndex = 8;
            this.lblTotalElections.Text = "Total elections ";
            this.lblTotalElections.Click += new System.EventHandler(this.lblTotalElections_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stats";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(16, 25);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(111, 32);
            this.lblWinner.TabIndex = 10;
            this.lblWinner.Text = "Winner";
            this.lblWinner.Click += new System.EventHandler(this.lblWinner_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalVotes);
            this.panel1.Location = new System.Drawing.Point(554, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 73);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total votes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalVoters);
            this.panel2.Location = new System.Drawing.Point(554, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 67);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total voters";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTotalElections);
            this.panel3.Location = new System.Drawing.Point(554, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 71);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Elections ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblWinner);
            this.panel4.Location = new System.Drawing.Point(554, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 66);
            this.panel4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Winner";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnElection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnCandidates);
            this.Controls.Add(this.btnParty);
            this.Name = "AdminDashboard";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParty;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElection;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTotalVotes;
        private System.Windows.Forms.Label lblTotalVoters;
        private System.Windows.Forms.Label lblTotalElections;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}