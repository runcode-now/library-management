namespace LibrayManagement
{
    partial class frmBookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookDetails));
            pboxBook = new PictureBox();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDescription = new TextBox();
            rdoOn = new RadioButton();
            lbStatus = new Label();
            rdoOff = new RadioButton();
            label8 = new Label();
            txtPublisher = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label9 = new Label();
            txtBookId = new TextBox();
            btnBorrow = new Button();
            btnCancel = new Button();
            label7 = new Label();
            txtBorrowed = new TextBox();
            numQuantity = new NumericUpDown();
            btnClose = new Button();
            btnRefresh = new Button();
            lbReturn = new Label();
            dtpReturn = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pboxBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // pboxBook
            // 
            pboxBook.BackgroundImage = (Image)resources.GetObject("pboxBook.BackgroundImage");
            pboxBook.Location = new Point(46, 84);
            pboxBook.Name = "pboxBook";
            pboxBook.Size = new Size(192, 257);
            pboxBook.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxBook.TabIndex = 0;
            pboxBook.TabStop = false;
            pboxBook.Click += pboxBook_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(360, 184);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 23);
            txtName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(360, 131);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(168, 23);
            cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 134);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 5;
            label2.Text = "Thể loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 6;
            label1.Text = "Chi tiết sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 187);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 7;
            label3.Text = "Tên sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(265, 242);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 9;
            label4.Text = "Tác giả";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(360, 239);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(225, 23);
            txtAuthor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(624, 190);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 11;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(265, 298);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 13;
            label6.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(360, 295);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(531, 109);
            txtDescription.TabIndex = 12;
            // 
            // rdoOn
            // 
            rdoOn.AutoSize = true;
            rdoOn.Location = new Point(719, 84);
            rdoOn.Name = "rdoOn";
            rdoOn.Size = new Size(67, 19);
            rdoOn.TabIndex = 14;
            rdoOn.TabStop = true;
            rdoOn.Text = "Hiển thị";
            rdoOn.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatus.Location = new Point(624, 84);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(66, 17);
            lbStatus.TabIndex = 15;
            lbStatus.Text = "Trạng thái";
            // 
            // rdoOff
            // 
            rdoOff.AutoSize = true;
            rdoOff.Location = new Point(816, 82);
            rdoOff.Name = "rdoOff";
            rdoOff.Size = new Size(40, 19);
            rdoOff.TabIndex = 16;
            rdoOff.TabStop = true;
            rdoOff.Text = "Ẩn";
            rdoOff.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(624, 138);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 18;
            label8.Text = "Nhà xuất bản";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(719, 135);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(172, 23);
            txtPublisher.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(477, 427);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 31);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(477, 427);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 31);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(701, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(265, 87);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 23;
            label9.Text = "Mã sách";
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(360, 84);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(168, 23);
            txtBookId.TabIndex = 22;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(477, 427);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(96, 31);
            btnBorrow.TabIndex = 24;
            btnBorrow.Text = "Muợn sách";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(701, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 31);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Hủy mượn";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(624, 242);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 27;
            label7.Text = "Đang mượn";
            // 
            // txtBorrowed
            // 
            txtBorrowed.Enabled = false;
            txtBorrowed.Location = new Point(719, 239);
            txtBorrowed.Name = "txtBorrowed";
            txtBorrowed.Size = new Size(172, 23);
            txtBorrowed.TabIndex = 26;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(719, 184);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(172, 23);
            numQuantity.TabIndex = 30;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(245, 427);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 31);
            btnClose.TabIndex = 31;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(701, 427);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 31);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Visible = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lbReturn
            // 
            lbReturn.AutoSize = true;
            lbReturn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbReturn.ForeColor = Color.Red;
            lbReturn.Location = new Point(624, 30);
            lbReturn.Name = "lbReturn";
            lbReturn.Size = new Size(92, 17);
            lbReturn.TabIndex = 34;
            lbReturn.Text = "Ngày trả sách";
            lbReturn.Visible = false;
            // 
            // dtpReturn
            // 
            dtpReturn.Location = new Point(719, 27);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(172, 23);
            dtpReturn.TabIndex = 35;
            dtpReturn.Visible = false;
            // 
            // frmBookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 520);
            Controls.Add(dtpReturn);
            Controls.Add(lbReturn);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(numQuantity);
            Controls.Add(label7);
            Controls.Add(txtBorrowed);
            Controls.Add(btnBorrow);
            Controls.Add(label9);
            Controls.Add(txtBookId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(txtPublisher);
            Controls.Add(rdoOff);
            Controls.Add(lbStatus);
            Controls.Add(rdoOn);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtName);
            Controls.Add(pboxBook);
            Name = "frmBookDetails";
            Text = "frmBookDetails";
            Load += frmBookDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pboxBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pboxBook;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtAuthor;
        private Label label5;
        private NumericUpDown numQuantity;
        private Label label6;
        private TextBox txtDescription;
        private RadioButton rdoOn;
        private Label lbStatus;
        private RadioButton rdoOff;
        private Label label8;
        private TextBox txtPublisher;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label9;
        private TextBox txtBookId;
        private Button btnBorrow;
        private Button btnCancel;
        private Label label7;
        private TextBox txtBorrowed;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Button btnClose;
        private Button btnRefresh;
        private Label lbReturn;
        private DateTimePicker dtpReturn;
    }
}