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
    public partial class frmLogin : Form
    {
        AccountRepository _repo = null;

        HistoryBookRepository _repoHis = new HistoryBookRepository();

        public frmLogin()
        {
            _repo = new AccountRepository();
            InitializeComponent();

            List<HistoryBook> hisList = _repoHis.GetAll().Where(x => x.HistoryReturn < DateTime.Now).ToList();

            foreach (HistoryBook his in hisList)
            {
                his.HistoryStatus = "warning";
                _repoHis.Update(his);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Account acc = _repo.CheckAccount(txtUsername.Text);
                if (acc == null) throw new Exception("Tài khoản không tồn tại.");
                else
                {
                    //if (!acc.AccountPassword.Equals(_repo.EncodeToSHA1(txtPassword.Text)))
                    if (!acc.AccountPassword.Equals(txtPassword.Text))
                        throw new Exception("Sai mật khẩu.");
                    else
                    {
                        this.Hide();
                        if (acc.AccountRole == 1)
                        {
                            frmHomeStudent stuForm = new frmHomeStudent()
                            {
                                account = acc
                            };
                            if (stuForm.ShowDialog() == DialogResult.OK)
                            {
                                this.Show();
                                frmLogin_Load(sender, e);
                            }
                        }
                        else
                        {
                            frmHomeAdmin stuForm = new frmHomeAdmin()
                            {
                                account = acc
                            };
                            if (stuForm.ShowDialog() == DialogResult.OK)
                            {
                                this.Show();
                                frmLogin_Load(sender, e);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkSigUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin_Load(sender, e);
            this.Hide();
            frmSignUp signupForm = new frmSignUp();
            signupForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
