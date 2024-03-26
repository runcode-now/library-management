using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrayManagement
{
    public partial class frmHistoryDetails : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();
        HistoryBookRepository _repoHis = new HistoryBookRepository();


        public HistoryBook history { get; set; }

        public string status { get; set; }

        public frmHistoryDetails()
        {
            InitializeComponent();
        }

        private void frmHistoryDetails_Load(object sender, EventArgs e)
        {
            Account account = _repoAcc.GetById(history.AccountId.Value);
            Book book = _repoBook.GetById(history.BookId.Value);
            Category cate = _repoCate.GetById(book.CategoryId.Value);

            // Load image book
            try
            {
                using (MemoryStream ms = new MemoryStream(book.BookImage))
                {
                    Image image = Image.FromStream(ms);
                    pboxBook.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            txtBookId.Text = book.BookId.ToString();
            cmbCategory.Text = cate.CategoryName.ToString();
            txtBookName.Text = book.BookTitle.ToString();
            txtAuthor.Text = book.BookAuthor.ToString();


            txtAccName.Text = account.AccountName.ToString();
            txtEmail.Text = account.AccountEmail.ToString();
            txtPhone.Text = account.AccountPhone.ToString();

            dtpExpected.Text = history.HistoryReturn.ToString();        // waiting -> ngay tra sach
            if (status.Equals("waiting"))
            {
                btnConfirm.Visible = false;
                lbActual.Visible = lbBorrow.Visible = false;
                dtpActual.Visible = dtpBorrow.Visible = false;
            }


            if (status.Equals("borrowed") || status.Equals("warning"))      // borrowed  -> ngay muon sach   
            {
                dtpBorrow.Text = history.HistoryBorrow.ToString();

                btnAccept.Visible = btnReject.Visible = false;
                btnConfirm.Visible = true;

                lbBorrow.Visible = dtpBorrow.Visible = true;
                lbActual.Visible = dtpActual.Visible = false;

            }


            if (status.Equals("returned"))                               // returned --> ngay tra thuc te
            {
                dtpBorrow.Text = history.HistoryBorrow.ToString();
                dtpActual.Text = history.HistoryActual.ToString();

                btnConfirm.Visible = btnAccept.Visible = btnReject.Visible = false;
                lbActual.Visible = lbBorrow.Visible = true;
                dtpActual.Visible = dtpBorrow.Visible = true;

                btnClose.Visible = false;
                button1.Visible = true;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            history.HistoryStatus = "borrowed";
            history.HistoryBorrow = DateTime.Now;

            _repoHis.Update(history);
            MessageBox.Show("Cập nhật thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClose_Click(sender, e);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Book book = _repoBook.GetById(history.BookId.Value);

            history.HistoryStatus = "cancel";
            book.BookBorrowed -= 1;

            _repoHis.Update(history);
            _repoBook.Update(book);
            MessageBox.Show("Cập nhật thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClose_Click(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Book book = _repoBook.GetById(history.BookId.Value);

            history.HistoryStatus = "returned";
            history.HistoryActual = DateTime.Now;
            book.BookBorrowed -= 1;

            _repoHis.Update(history);
            _repoBook.Update(book);
            MessageBox.Show("Cập nhật thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClose_Click(sender, e);
        }

        private void llBookDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Book book = _repoBook.GetById(history.BookId.Value);
            frmBookDetails bdetailsForm = new frmBookDetails()
            {
                action = "update",
                book = book,
                role = 0
            };
            if(bdetailsForm.ShowDialog() == DialogResult.OK)
            {
                frmHistoryDetails_Load(sender, e);
            }
        }
    }
}
