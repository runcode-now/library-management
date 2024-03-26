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
    public partial class frmSignUp : Form
    {
        AccountRepository _repoAcc = new AccountRepository();

        public int role { get; set; }

        public frmSignUp()
        {
            role = 1;
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check username must be length >= 6 character
            if (txtUsername.Text.Trim().Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải chứa tối thiểu 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check username exist
            Account account = _repoAcc.CheckAccount(txtUsername.Text);
            if (account != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check password
            if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ cái và một số, và có ít nhất 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Check email
            if (!Regex.IsMatch(txtEmail.Text, "^[a-zA-Z0-9]+@[a-zA-Z0-9.]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtPassword.Text.Equals(txtPasswordCf.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận phải trùng với mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check format phone
            if (txtPhone.Text.Length == null || txtPhone.Text.Length != 10 || !txtPhone.Text.StartsWith('0'))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check date
            if (DateTime.Parse(dtpDob.Text) > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string sex = "male";
            if (rdoFemale.Checked) sex = "female";


            // Set default image (avatar)
            try
            {
                string defaultImagePath = "D:/avatar-trang-4.jpg";

                byte[] imageData;
                using (FileStream fs = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }

                // Lưu imageData vào cơ sở dữ liệu
                Account acc = new Account()
                {
                    AccountUsername = txtUsername.Text,
                    AccountPassword = _repoAcc.EncodeToSHA1(txtPassword.Text),
                    AccountName = txtName.Text,
                    AccountEmail = txtEmail.Text,
                    AccountDob = DateTime.Parse(dtpDob.Text),
                    AccountPhone = txtPhone.Text,
                    AccountRole = role,
                    AccountSex = sex,
                    AccountAvatar = imageData
                };

                _repoAcc.Create(acc);
                MessageBox.Show("Đăng kí tài khoản thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if(role == 0)
                this.DialogResult = DialogResult.OK;
            frmSignUp_Load(sender, e);
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if(role == 0)
            {
                linkLogin.Visible = false;
                btnCancel.Visible = false;
            }

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPasswordCf.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            rdoMale.Checked = true;
            dtpDob.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
