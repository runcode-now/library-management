namespace LibrayManagement
{
    partial class frmHomeAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeAdmin));
            menuStrip1 = new MenuStrip();
            quảnLíSáchToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            đangChờXácNhậnToolStripMenuItem = new ToolStripMenuItem();
            đangMượnToolStripMenuItem = new ToolStripMenuItem();
            đãTrảToolStripMenuItem = new ToolStripMenuItem();
            quáHạnToolStripMenuItem = new ToolStripMenuItem();
            biểuĐồToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnCáNhânToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đăngKíToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            cmbCategory = new ComboBox();
            dgvBook = new DataGridView();
            btnNew = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLíSáchToolStripMenuItem, thốngKêToolStripMenuItem, tàiKhoảnCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem, đăngKíToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíSáchToolStripMenuItem
            // 
            quảnLíSáchToolStripMenuItem.Image = (Image)resources.GetObject("quảnLíSáchToolStripMenuItem.Image");
            quảnLíSáchToolStripMenuItem.Name = "quảnLíSáchToolStripMenuItem";
            quảnLíSáchToolStripMenuItem.Size = new Size(100, 20);
            quảnLíSáchToolStripMenuItem.Text = "Quản lí sách";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đangChờXácNhậnToolStripMenuItem, đangMượnToolStripMenuItem, đãTrảToolStripMenuItem, quáHạnToolStripMenuItem, biểuĐồToolStripMenuItem });
            thốngKêToolStripMenuItem.Image = (Image)resources.GetObject("thốngKêToolStripMenuItem.Image");
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // đangChờXácNhậnToolStripMenuItem
            // 
            đangChờXácNhậnToolStripMenuItem.Image = (Image)resources.GetObject("đangChờXácNhậnToolStripMenuItem.Image");
            đangChờXácNhậnToolStripMenuItem.Name = "đangChờXácNhậnToolStripMenuItem";
            đangChờXácNhậnToolStripMenuItem.Size = new Size(180, 22);
            đangChờXácNhậnToolStripMenuItem.Text = "Đang chờ xác nhận";
            đangChờXácNhậnToolStripMenuItem.Click += waiting_Click;
            // 
            // đangMượnToolStripMenuItem
            // 
            đangMượnToolStripMenuItem.Image = (Image)resources.GetObject("đangMượnToolStripMenuItem.Image");
            đangMượnToolStripMenuItem.Name = "đangMượnToolStripMenuItem";
            đangMượnToolStripMenuItem.Size = new Size(180, 22);
            đangMượnToolStripMenuItem.Text = "Đang mượn";
            đangMượnToolStripMenuItem.Click += borrow_Click;
            // 
            // đãTrảToolStripMenuItem
            // 
            đãTrảToolStripMenuItem.Image = (Image)resources.GetObject("đãTrảToolStripMenuItem.Image");
            đãTrảToolStripMenuItem.Name = "đãTrảToolStripMenuItem";
            đãTrảToolStripMenuItem.Size = new Size(180, 22);
            đãTrảToolStripMenuItem.Text = "Đã trả";
            đãTrảToolStripMenuItem.Click += return_Click;
            // 
            // quáHạnToolStripMenuItem
            // 
            quáHạnToolStripMenuItem.Image = (Image)resources.GetObject("quáHạnToolStripMenuItem.Image");
            quáHạnToolStripMenuItem.Name = "quáHạnToolStripMenuItem";
            quáHạnToolStripMenuItem.Size = new Size(180, 22);
            quáHạnToolStripMenuItem.Text = "Quá hạn";
            quáHạnToolStripMenuItem.Click += warning_Click;
            // 
            // biểuĐồToolStripMenuItem
            // 
            biểuĐồToolStripMenuItem.Image = (Image)resources.GetObject("biểuĐồToolStripMenuItem.Image");
            biểuĐồToolStripMenuItem.Name = "biểuĐồToolStripMenuItem";
            biểuĐồToolStripMenuItem.Size = new Size(180, 22);
            biểuĐồToolStripMenuItem.Text = "Biểu đồ";
            biểuĐồToolStripMenuItem.Click += barchart_Click;
            // 
            // tàiKhoảnCáNhânToolStripMenuItem
            // 
            tàiKhoảnCáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
            tàiKhoảnCáNhânToolStripMenuItem.Image = (Image)resources.GetObject("tàiKhoảnCáNhânToolStripMenuItem.Image");
            tàiKhoảnCáNhânToolStripMenuItem.Name = "tàiKhoảnCáNhânToolStripMenuItem";
            tàiKhoảnCáNhânToolStripMenuItem.Size = new Size(130, 20);
            tàiKhoảnCáNhânToolStripMenuItem.Text = "Tài khoản cá nhân";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(177, 22);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += profile_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Image = (Image)resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image");
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(177, 22);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += changepassword_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(171, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng kí tài khoản quản trị";
            đăngXuấtToolStripMenuItem.Click += signup_Click;
            // 
            // đăngKíToolStripMenuItem
            // 
            đăngKíToolStripMenuItem.Image = (Image)resources.GetObject("đăngKíToolStripMenuItem.Image");
            đăngKíToolStripMenuItem.Name = "đăngKíToolStripMenuItem";
            đăngKíToolStripMenuItem.Size = new Size(89, 20);
            đăngKíToolStripMenuItem.Text = "Đăng xuất";
            đăngKíToolStripMenuItem.Click += logout_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Location = new Point(41, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 80);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(537, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 5;
            label2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(612, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 3;
            label1.Text = "Thể loại";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(100, 31);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(35, 179);
            dgvBook.Name = "dgvBook";
            dgvBook.RowTemplate.Height = 25;
            dgvBook.Size = new Size(881, 376);
            dgvBook.TabIndex = 7;
            dgvBook.SelectionChanged += dgvBook_SelectionChanged;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(806, 150);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 23);
            btnNew.TabIndex = 9;
            btnNew.Text = "Thêm sách";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmHomeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 586);
            Controls.Add(btnNew);
            Controls.Add(groupBox1);
            Controls.Add(dgvBook);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHomAdmin";
            Load += frmHomeAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLíSáchToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem đangChờXácNhậnToolStripMenuItem;
        private ToolStripMenuItem đangMượnToolStripMenuItem;
        private ToolStripMenuItem đãTrảToolStripMenuItem;
        private ToolStripMenuItem quáHạnToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tàiKhoảnCáNhânToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đăngKíToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private ComboBox cmbCategory;
        private DataGridView dgvBook;
        private Button btnNew;
        private ToolStripMenuItem biểuĐồToolStripMenuItem;
    }
}