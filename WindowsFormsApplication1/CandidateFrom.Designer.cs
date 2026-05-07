namespace DB__PROJECT
{
    partial class CandidateForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtManifesto = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.cmbElection = new System.Windows.Forms.ComboBox();
            this.party = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConstituencyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(289, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(98, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 51);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(94, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter name";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(289, 165);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 22);
            this.txtAge.TabIndex = 7;
            // 
            // txtManifesto
            // 
            this.txtManifesto.Location = new System.Drawing.Point(289, 209);
            this.txtManifesto.Name = "txtManifesto";
            this.txtManifesto.Size = new System.Drawing.Size(121, 22);
            this.txtManifesto.TabIndex = 8;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Age.Location = new System.Drawing.Point(97, 167);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(38, 20);
            this.Age.TabIndex = 9;
            this.Age.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(94, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manifesto";
            // 
            // cmbParty
            // 
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(289, 253);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(121, 24);
            this.cmbParty.TabIndex = 11;
            this.cmbParty.Click += new System.EventHandler(this.CandidateForm_Load);
            // 
            // cmbElection
            // 
            this.cmbElection.FormattingEnabled = true;
            this.cmbElection.Location = new System.Drawing.Point(289, 299);
            this.cmbElection.Name = "cmbElection";
            this.cmbElection.Size = new System.Drawing.Size(121, 24);
            this.cmbElection.TabIndex = 12;
            // 
            // party
            // 
            this.party.AutoSize = true;
            this.party.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.party.Location = new System.Drawing.Point(97, 257);
            this.party.Name = "party";
            this.party.Size = new System.Drawing.Size(48, 20);
            this.party.TabIndex = 13;
            this.party.Text = "Party";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(97, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Election";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(380, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "ADD CANDIDATE";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "                                TERMS & INSTRUCTIONS",
            "",
            "    > Enter accurate candidate details (Name, Party, Constituency).",
            "",
            "    > Ensure the candidate belongs to the selected constituency.",
            "",
            "    > Avoid duplicate entries for the same candidate.",
            "",
            "    > All required fields must be filled correctly.",
            "",
            "    > Only authorized admins can add candidates.",
            "",
            "    > Verify information before saving.",
            "",
            "",
            "     *Note: Incorrect or duplicate entries may be removed by",
            "       the system."});
            this.listBox1.Location = new System.Drawing.Point(579, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 260);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(98, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Constituency_id";
            // 
            // txtConstituencyID
            // 
            this.txtConstituencyID.Location = new System.Drawing.Point(289, 79);
            this.txtConstituencyID.Name = "txtConstituencyID";
            this.txtConstituencyID.Size = new System.Drawing.Size(121, 22);
            this.txtConstituencyID.TabIndex = 18;
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.txtConstituencyID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.party);
            this.Controls.Add(this.cmbElection);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.txtManifesto);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Name = "CandidateForm";
            this.Text = "e";
            this.Load += new System.EventHandler(this.CandidateForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtManifesto;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.ComboBox cmbElection;
        private System.Windows.Forms.Label party;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConstituencyID;
    }
}