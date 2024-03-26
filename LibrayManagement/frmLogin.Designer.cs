namespace LibrayManagement
{
    partial class frmLogin
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            linkSigUp = new LinkLabel();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 116);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(117, 187);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkSigUp
            // 
            linkSigUp.AutoSize = true;
            linkSigUp.Location = new Point(213, 254);
            linkSigUp.Name = "linkSigUp";
            linkSigUp.Size = new Size(99, 15);
            linkSigUp.TabIndex = 5;
            linkSigUp.TabStop = true;
            linkSigUp.Text = "Đăng kí tài khoản";
            linkSigUp.LinkClicked += linkSigUp_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 28);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(521, 300);
            Controls.Add(btnCancel);
            Controls.Add(linkSigUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private LinkLabel linkSigUp;
        private Button btnCancel;
    }
}