namespace LibrayManagement
{
    partial class frmStatusBook
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
            dgvBook = new DataGridView();
            lbTitle = new Label();
            btnClose = new Button();
            linkWarning = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(42, 78);
            dgvBook.Name = "dgvBook";
            dgvBook.RowTemplate.Height = 25;
            dgvBook.Size = new Size(726, 346);
            dgvBook.TabIndex = 2;
            dgvBook.SelectionChanged += dgvBook_SelectionChanged;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(230, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(367, 30);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Những cuốn sách đang chờ xác nhận";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(365, 451);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 31);
            btnClose.TabIndex = 33;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // linkWarning
            // 
            linkWarning.AutoSize = true;
            linkWarning.Location = new Point(654, 437);
            linkWarning.Name = "linkWarning";
            linkWarning.Size = new Size(114, 15);
            linkWarning.TabIndex = 34;
            linkWarning.TabStop = true;
            linkWarning.Text = "Nhắc nhở qua email";
            linkWarning.Visible = false;
            linkWarning.LinkClicked += linkWarning_LinkClicked;
            // 
            // frmStatusBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(linkWarning);
            Controls.Add(btnClose);
            Controls.Add(lbTitle);
            Controls.Add(dgvBook);
            Name = "frmStatusBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStatusBook";
            Load += frmStatusBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBook;
        private Label lbTitle;
        private Button btnClose;
        private LinkLabel linkWarning;
    }
}