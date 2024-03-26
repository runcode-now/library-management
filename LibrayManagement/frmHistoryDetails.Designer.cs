namespace LibrayManagement
{
    partial class frmHistoryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryDetails));
            dtpExpected = new DateTimePicker();
            btnClose = new Button();
            lbExpected = new Label();
            label9 = new Label();
            txtBookId = new TextBox();
            btnReject = new Button();
            btnAccept = new Button();
            label8 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtAuthor = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbCategory = new ComboBox();
            txtBookName = new TextBox();
            pboxBook = new PictureBox();
            label6 = new Label();
            txtAccName = new TextBox();
            txtPhone = new TextBox();
            dtpBorrow = new DateTimePicker();
            lbBorrow = new Label();
            dtpActual = new DateTimePicker();
            lbActual = new Label();
            llBookDetails = new LinkLabel();
            btnConfirm = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxBook).BeginInit();
            SuspendLayout();
            // 
            // dtpExpected
            // 
            dtpExpected.Enabled = false;
            dtpExpected.Location = new Point(710, 252);
            dtpExpected.Name = "dtpExpected";
            dtpExpected.Size = new Size(172, 23);
            dtpExpected.TabIndex = 64;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(256, 426);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 31);
            btnClose.TabIndex = 61;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbExpected
            // 
            lbExpected.AutoSize = true;
            lbExpected.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbExpected.Location = new Point(615, 255);
            lbExpected.Name = "lbExpected";
            lbExpected.Size = new Size(89, 17);
            lbExpected.TabIndex = 59;
            lbExpected.Text = "Ngày trả sách";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(256, 100);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 55;
            label9.Text = "Mã sách";
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(351, 97);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(184, 23);
            txtBookId.TabIndex = 54;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(699, 426);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(96, 31);
            btnReject.TabIndex = 53;
            btnReject.Text = "Từ chối";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(473, 426);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(96, 31);
            btnAccept.TabIndex = 52;
            btnAccept.Text = "Chấp nhận";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(615, 151);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 50;
            label8.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(710, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(615, 203);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 44;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(256, 255);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 43;
            label4.Text = "Tác giả";
            // 
            // txtAuthor
            // 
            txtAuthor.Enabled = false;
            txtAuthor.Location = new Point(351, 252);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(184, 23);
            txtAuthor.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 200);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 41;
            label3.Text = "Tên sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(393, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 40;
            label1.Text = "Chi tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(256, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 39;
            label2.Text = "Thể loại";
            // 
            // cmbCategory
            // 
            cmbCategory.Enabled = false;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(351, 144);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(184, 23);
            cmbCategory.TabIndex = 38;
            // 
            // txtBookName
            // 
            txtBookName.Enabled = false;
            txtBookName.Location = new Point(351, 197);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(184, 23);
            txtBookName.TabIndex = 37;
            // 
            // pboxBook
            // 
            pboxBook.BackgroundImage = (Image)resources.GetObject("pboxBook.BackgroundImage");
            pboxBook.Location = new Point(37, 97);
            pboxBook.Name = "pboxBook";
            pboxBook.Size = new Size(192, 257);
            pboxBook.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxBook.TabIndex = 36;
            pboxBook.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(615, 100);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 66;
            label6.Text = "Họ tên";
            // 
            // txtAccName
            // 
            txtAccName.Enabled = false;
            txtAccName.Location = new Point(710, 97);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(172, 23);
            txtAccName.TabIndex = 65;
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(710, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 23);
            txtPhone.TabIndex = 67;
            // 
            // dtpBorrow
            // 
            dtpBorrow.Enabled = false;
            dtpBorrow.Location = new Point(710, 307);
            dtpBorrow.Name = "dtpBorrow";
            dtpBorrow.Size = new Size(172, 23);
            dtpBorrow.TabIndex = 69;
            // 
            // lbBorrow
            // 
            lbBorrow.AutoSize = true;
            lbBorrow.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbBorrow.Location = new Point(615, 310);
            lbBorrow.Name = "lbBorrow";
            lbBorrow.Size = new Size(77, 17);
            lbBorrow.TabIndex = 68;
            lbBorrow.Text = "Ngày mượn";
            // 
            // dtpActual
            // 
            dtpActual.Enabled = false;
            dtpActual.Location = new Point(710, 359);
            dtpActual.Name = "dtpActual";
            dtpActual.Size = new Size(172, 23);
            dtpActual.TabIndex = 71;
            // 
            // lbActual
            // 
            lbActual.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbActual.Location = new Point(615, 355);
            lbActual.Name = "lbActual";
            lbActual.Size = new Size(85, 36);
            lbActual.TabIndex = 70;
            lbActual.Text = "Ngày trả thực tế";
            // 
            // llBookDetails
            // 
            llBookDetails.AutoSize = true;
            llBookDetails.Location = new Point(256, 312);
            llBookDetails.Name = "llBookDetails";
            llBookDetails.Size = new Size(72, 15);
            llBookDetails.TabIndex = 72;
            llBookDetails.TabStop = true;
            llBookDetails.Text = "Chi tiết sách";
            llBookDetails.LinkClicked += llBookDetails_LinkClicked;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(587, 426);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(96, 31);
            btnConfirm.TabIndex = 73;
            btnConfirm.Text = "Đã trả sách";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(473, 463);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 75;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // frmHistoryDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 532);
            Controls.Add(button1);
            Controls.Add(btnConfirm);
            Controls.Add(llBookDetails);
            Controls.Add(dtpActual);
            Controls.Add(lbActual);
            Controls.Add(dtpBorrow);
            Controls.Add(lbBorrow);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtAccName);
            Controls.Add(dtpExpected);
            Controls.Add(btnClose);
            Controls.Add(lbExpected);
            Controls.Add(label9);
            Controls.Add(txtBookId);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtBookName);
            Controls.Add(pboxBook);
            Name = "frmHistoryDetails";
            Text = "frmHistoryDetails";
            Load += frmHistoryDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pboxBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpExpected;
        private Button btnClose;
        private Label lbExpected;
        private Label label9;
        private TextBox txtBookId;
        private Button btnReject;
        private Button btnAccept;
        private Label label8;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private TextBox txtAuthor;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategory;
        private TextBox txtBookName;
        private PictureBox pboxBook;
        private Label label6;
        private TextBox txtAccName;
        private TextBox txtPhone;
        private DateTimePicker dtpBorrow;
        private Label lbBorrow;
        private DateTimePicker dtpActual;
        private Label lbActual;
        private LinkLabel llBookDetails;
        private Button btnConfirm;
        private Button button1;
    }
}