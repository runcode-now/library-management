using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrayManagement
{
    public partial class frmProfile : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        LibraryManagementContext _context = new LibraryManagementContext();

        public Account account { get; set; }

        public frmProfile()
        {
            InitializeComponent();
            txtUsername.Enabled = false;

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = account.AccountName;
            txtEmail.Text = account.AccountEmail;
            txtPhone.Text = account.AccountPhone;
            txtUsername.Text = account.AccountUsername;
            dtpDob.Text = account.AccountDob.ToString();

            string sex = account.AccountSex;
            if (sex.Equals("male")) rdoMale.Checked = true;
            if (sex.Equals("female")) rdoFemale.Checked = true;

            try
            {
                using (MemoryStream ms = new MemoryStream(account.AccountAvatar))
                {
                    Image image = Image.FromStream(ms);
                    pboxAvatar.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void pboxAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    byte[] imageData;
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }

                    // Lưu imageData vào cơ sở dữ liệu
                    account.AccountAvatar = imageData;
                    _repoAcc.Update(account);

                    frmProfile_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sex = "male";
            if (rdoFemale.Checked) sex = "female";

            string phone = txtPhone.Text;
            if (phone.Length != 10 || !phone.StartsWith('0'))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.");
                return;
            }

            account.AccountName = txtName.Text;
            account.AccountUsername = txtUsername.Text;
            account.AccountEmail = txtEmail.Text;
            account.AccountDob = DateTime.Parse(dtpDob.Text);
            account.AccountPhone = txtPhone.Text;
            account.AccountSex = sex;

            _repoAcc.Update(account);
            _context.SaveChanges();

            MessageBox.Show("Cập nhật thông tin thành công.");
            frmProfile_Load(sender, e);
        }

    }
}
