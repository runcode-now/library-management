using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrayManagement
{
    public partial class frmPassword : Form
    {
        AccountRepository _repoAcc = new AccountRepository();

        public Account account { get; set; }


        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_repoAcc.EncodeToSHA1(txtOld.Text).Equals(account.AccountPassword))
            {
                MessageBox.Show("Sai mật khẩu cũ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPassword = txtNew.Text;
            if (!Regex.IsMatch(newPassword, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
            {
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất một chữ cái và một số, và có ít nhất 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtNew.Text.Equals(txtNewConfirm.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận phải trùng với mật khẩu mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            account.AccountPassword = _repoAcc.EncodeToSHA1(newPassword);
            _repoAcc.Update(account);

            MessageBox.Show("Đổi mật khẩu thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
