namespace LibrayManagement
{
    partial class frmPassword
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
            txtOld = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNew = new TextBox();
            label4 = new Label();
            txtNewConfirm = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 22);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 0;
            label1.Text = "Thay đổi mật khẩu";
            // 
            // txtOld
            // 
            txtOld.Location = new Point(194, 83);
            txtOld.Name = "txtOld";
            txtOld.Size = new Size(202, 23);
            txtOld.TabIndex = 1;
            txtOld.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 129);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới";
            // 
            // txtNew
            // 
            txtNew.Location = new Point(195, 126);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(202, 23);
            txtNew.TabIndex = 3;
            txtNew.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 173);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 6;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // txtNewConfirm
            // 
            txtNewConfirm.Location = new Point(195, 170);
            txtNewConfirm.Name = "txtNewConfirm";
            txtNewConfirm.Size = new Size(202, 23);
            txtNewConfirm.TabIndex = 5;
            txtNewConfirm.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(95, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Đóng";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Location = new Point(260, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 27);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 274);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(txtNewConfirm);
            Controls.Add(label3);
            Controls.Add(txtNew);
            Controls.Add(label2);
            Controls.Add(txtOld);
            Controls.Add(label1);
            Name = "frmPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOld;
        private Label label2;
        private Label label3;
        private TextBox txtNew;
        private Label label4;
        private TextBox txtNewConfirm;
        private Button btnCancel;
        private Button btnUpdate;
    }
}