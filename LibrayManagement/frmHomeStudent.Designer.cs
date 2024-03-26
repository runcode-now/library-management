namespace LibrayManagement
{
    partial class frmHomeStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeStudent));
            menuStrip1 = new MenuStrip();
            library = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            sáchĐangChờXácNhậnToolStripMenuItem = new ToolStripMenuItem();
            sáchĐangMượnToolStripMenuItem = new ToolStripMenuItem();
            sáchĐãTrảToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            profile = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            dgvBook = new DataGridView();
            cmbCategory = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { library, sáchToolStripMenuItem, tàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // library
            // 
            library.Image = (Image)resources.GetObject("library.Image");
            library.Name = "library";
            library.Size = new Size(80, 20);
            library.Text = "Thư viện";
            library.Click += library_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sáchĐangChờXácNhậnToolStripMenuItem, sáchĐangMượnToolStripMenuItem, sáchĐãTrảToolStripMenuItem });
            sáchToolStripMenuItem.Image = (Image)resources.GetObject("sáchToolStripMenuItem.Image");
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(60, 20);
            sáchToolStripMenuItem.Text = "Sách";
            // 
            // sáchĐangChờXácNhậnToolStripMenuItem
            // 
            sáchĐangChờXácNhậnToolStripMenuItem.Image = (Image)resources.GetObject("sáchĐangChờXácNhậnToolStripMenuItem.Image");
            sáchĐangChờXácNhậnToolStripMenuItem.Name = "sáchĐangChờXácNhậnToolStripMenuItem";
            sáchĐangChờXácNhậnToolStripMenuItem.Size = new Size(203, 22);
            sáchĐangChờXácNhậnToolStripMenuItem.Text = "Sách đang chờ xác nhận";
            sáchĐangChờXácNhậnToolStripMenuItem.Click += waiting_Click;
            // 
            // sáchĐangMượnToolStripMenuItem
            // 
            sáchĐangMượnToolStripMenuItem.Image = (Image)resources.GetObject("sáchĐangMượnToolStripMenuItem.Image");
            sáchĐangMượnToolStripMenuItem.Name = "sáchĐangMượnToolStripMenuItem";
            sáchĐangMượnToolStripMenuItem.Size = new Size(203, 22);
            sáchĐangMượnToolStripMenuItem.Text = "Sách đang mượn";
            sáchĐangMượnToolStripMenuItem.Click += borrowed_Click;
            // 
            // sáchĐãTrảToolStripMenuItem
            // 
            sáchĐãTrảToolStripMenuItem.Image = (Image)resources.GetObject("sáchĐãTrảToolStripMenuItem.Image");
            sáchĐãTrảToolStripMenuItem.Name = "sáchĐãTrảToolStripMenuItem";
            sáchĐãTrảToolStripMenuItem.Size = new Size(203, 22);
            sáchĐãTrảToolStripMenuItem.Text = "Sách đã trả";
            sáchĐãTrảToolStripMenuItem.Click += returned_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem1 });
            tàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("tàiKhoảnToolStripMenuItem.Image");
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 20);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(177, 22);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += profile_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            đổiMậtKhẩuToolStripMenuItem1.Image = (Image)resources.GetObject("đổiMậtKhẩuToolStripMenuItem1.Image");
            đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            đổiMậtKhẩuToolStripMenuItem1.Size = new Size(177, 22);
            đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem1.Click += changepassword_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(89, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += logout_Click;
            // 
            // profile
            // 
            profile.Name = "profile";
            profile.Size = new Size(180, 22);
            profile.Text = "Thông tin cá nhân";
            profile.Click += profile_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(180, 22);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(38, 187);
            dgvBook.Name = "dgvBook";
            dgvBook.RowTemplate.Height = 25;
            dgvBook.Size = new Size(719, 300);
            dgvBook.TabIndex = 1;
            dgvBook.SelectionChanged += dgvBook_SelectionChanged;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(453, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(378, 31);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 5;
            label2.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Location = new Point(38, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 80);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc ";
            // 
            // frmHomeStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(groupBox1);
            Controls.Add(dgvBook);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHomeStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHomeStudent";
            Load += frmHomeStudent_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem library;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem sáchĐangChờXácNhậnToolStripMenuItem;
        private ToolStripMenuItem sáchĐangMượnToolStripMenuItem;
        private ToolStripMenuItem sáchĐãTrảToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;

        private ToolStripMenuItem profile;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private DataGridView dgvBook;
        private ComboBox cmbCategory;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private GroupBox groupBox1;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
    }
}