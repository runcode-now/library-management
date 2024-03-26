namespace LibrayManagement
{
    partial class frmSignUp
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
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtPasswordCf = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtpDob = new DateTimePicker();
            label9 = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            btnSignUp = new Button();
            linkLogin = new LinkLabel();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 22);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 55);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(143, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txtPasswordCf
            // 
            txtPasswordCf.Location = new Point(143, 167);
            txtPasswordCf.Name = "txtPasswordCf";
            txtPasswordCf.Size = new Size(191, 23);
            txtPasswordCf.TabIndex = 6;
            txtPasswordCf.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 173);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 5;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(138, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(191, 23);
            txtPhone.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 132);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 85);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 34);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Họ tên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 175);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 13;
            label8.Text = "Giới tính";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPasswordCf);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 260);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDob);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(rdoFemale);
            groupBox2.Controls.Add(rdoMale);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(420, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 260);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin cá nhân";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(138, 212);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(191, 23);
            dtpDob.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 218);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 16;
            label9.Text = "Ngày sinh";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(247, 171);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(41, 19);
            rdoFemale.TabIndex = 15;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(162, 171);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 14;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(420, 371);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(101, 31);
            btnSignUp.TabIndex = 17;
            btnSignUp.Text = "Đăng kí";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(378, 421);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(65, 15);
            linkLogin.TabIndex = 18;
            linkLogin.TabStop = true;
            linkLogin.Text = "Đăng nhập";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(286, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 31);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSignUp
            // 
            AcceptButton = btnSignUp;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 459);
            Controls.Add(btnCancel);
            Controls.Add(linkLogin);
            Controls.Add(btnSignUp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmSignUp";
            Text = "frmSignUp";
            Load += frmSignUp_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtPasswordCf;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtName;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private DateTimePicker dtpDob;
        private Label label9;
        private Button btnSignUp;
        private LinkLabel linkLogin;
        private Button btnCancel;
    }
}