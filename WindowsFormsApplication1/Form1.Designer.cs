namespace DB__PROJECT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbVoter = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ONLINE VOTING SYSTEM ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(297, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbAdmin.Location = new System.Drawing.Point(85, 138);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbAdmin.TabIndex = 4;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // rbVoter
            // 
            this.rbVoter.AutoSize = true;
            this.rbVoter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rbVoter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbVoter.Location = new System.Drawing.Point(85, 104);
            this.rbVoter.Name = "rbVoter";
            this.rbVoter.Size = new System.Drawing.Size(63, 21);
            this.rbVoter.TabIndex = 5;
            this.rbVoter.TabStop = true;
            this.rbVoter.Text = "Voter";
            this.rbVoter.UseVisualStyleBackColor = false;
            this.rbVoter.CheckedChanged += new System.EventHandler(this.rbVoter_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(84, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(297, 214);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 22);
            this.txtCNIC.TabIndex = 7;
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmail.Location = new System.Drawing.Point(82, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Enter Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPassword.Location = new System.Drawing.Point(82, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Enter Password";
            this.lblPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCNIC.Location = new System.Drawing.Point(82, 219);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(77, 17);
            this.lblCNIC.TabIndex = 10;
            this.lblCNIC.Text = "Enter CNIC";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "                                        INSTRUCTIONS",
            "",
            "",
            "    > Log in using your registered CNIC/Email and Password.",
            "",
            "    > Each voter can cast only one vote.",
            "",
            "    > Verify your details before voting.",
            "",
            "    > Select your candidate carefully.",
            "",
            "    > Click “Submit Vote” to confirm (cannot be changed later).",
            "",
            "    > Do not share your login credentials.",
            "",
            "    > Logout after completing your vote.",
            "",
            "",
            "",
            "     *Note: Your vote is secure and confidential."});
            this.listBox1.Location = new System.Drawing.Point(552, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 320);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbVoter);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DB Connection Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbVoter;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.ListBox listBox1;
    }
}