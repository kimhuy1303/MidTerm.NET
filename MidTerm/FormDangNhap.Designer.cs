namespace MidTerm
{
    partial class FormDangNhap
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
            panel1 = new Panel();
            txtUsername = new TextBox();
            lblUsername = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(14, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 71);
            panel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(175, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(393, 29);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(35, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(109, 22);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username ";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Location = new Point(14, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 71);
            panel2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(175, 26);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(393, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(35, 26);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 22);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(14, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 71);
            panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.OrangeRed;
            btnClose.Location = new Point(434, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(134, 42);
            btnClose.TabIndex = 1;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(261, 13);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 42);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 296);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsername;
        private Label lblUsername;
        private Panel panel2;
        private TextBox txtPassword;
        private Label lblPassword;
        private Panel panel3;
        private Button btnLogin;
        private Button btnClose;
    }
}