namespace LibrayManagement
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            label1 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            dtpDob = new DateTimePicker();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            btnUpdate = new Button();
            pboxAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 222);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 219);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 284);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(166, 347);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(187, 23);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 350);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(401, 347);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 10;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(401, 281);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(508, 216);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 23);
            txtUsername.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(401, 219);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 6;
            label6.Text = "Tên đăng nhập";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(508, 280);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(187, 23);
            dtpDob.TabIndex = 12;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(508, 345);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 13;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(601, 344);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(41, 19);
            rdoFemale.TabIndex = 14;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(337, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 27);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pboxAvatar
            // 
            pboxAvatar.BackgroundImage = (Image)resources.GetObject("pboxAvatar.BackgroundImage");
            pboxAvatar.Image = (Image)resources.GetObject("pboxAvatar.Image");
            pboxAvatar.Location = new Point(307, 34);
            pboxAvatar.Name = "pboxAvatar";
            pboxAvatar.Size = new Size(150, 150);
            pboxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxAvatar.TabIndex = 16;
            pboxAvatar.TabStop = false;
            pboxAvatar.Click += pboxAvatar_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 498);
            Controls.Add(pboxAvatar);
            Controls.Add(btnUpdate);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(dtpDob);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProfile";
            Load += frmProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pboxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private Label label6;
        private DateTimePicker dtpDob;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Button btnUpdate;
        private PictureBox pboxAvatar;
    }
}