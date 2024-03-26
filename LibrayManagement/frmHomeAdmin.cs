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
    public partial class frmHomeAdmin : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();

        public Account account { get; set; }

        public frmHomeAdmin()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmHomeAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> categories = _repoCate.GetAll().Select(cate => cate.CategoryName).ToList();

                categories.Insert(0, "Tất cả");

                cmbCategory.DataSource = categories;
                //cmbCategory.DataSource = (from cate in _repoCate.GetAll()
                //                          select cate.CategoryName).ToList();
                dgvBook.DataSource = (from book in _repoBook.GetAll()
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          BookStatus = book.BookStatus == "on" ? "Hiển thị" : "Ẩn",
                                          book.BookBorrowed
                                      }).ToList();

                dgvBook.Columns["BookId"].HeaderText = "Mã sách";
                dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
                dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
                dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
                dgvBook.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
                dgvBook.Columns["BookQuantity"].HeaderText = "Số lượng";
                dgvBook.Columns["BookStatus"].HeaderText = "Trạng thái";
                dgvBook.Columns["BookBorrowed"].HeaderText = "Đang mượn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profile_Click(object sender, EventArgs e)
        {
            frmProfile profileForm = new frmProfile()
            {
                account = account
            };

            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            frmPassword passwordForm = new frmPassword()
            {
                account = account
            };

            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            frmSignUp signupForm = new frmSignUp()
            {
                role = 0
            };

            if (signupForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cate = _repoCate.GetAll().SingleOrDefault(x => cmbCategory.Text.Equals(x.CategoryName));

            string search = txtSearch.Text == null ? "" : txtSearch.Text;
            dgvBook.DataSource = null;
            if (cmbCategory.Text.Equals("Tất cả"))
            {
                dgvBook.DataSource = (from book in _repoBook.GetAll()
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      where book.BookTitle.ToLower().Contains(search.ToLower())
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          BookStatus = book.BookStatus == "on" ? "Hiển thị" : "Ẩn",
                                          book.BookBorrowed
                                      }).ToList();
            }
            else
            {
                dgvBook.DataSource = (from book in _repoBook.GetAll()
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      where book.CategoryId == cate.CategoryId && book.BookTitle.ToLower().Contains(search.ToLower())
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          BookStatus = book.BookStatus == "on" ? "Hiển thị" : "Ẩn",
                                          book.BookBorrowed
                                      }).ToList();
            }
            dgvBook.Columns["BookId"].HeaderText = "Mã sách";
            dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
            dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
            dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
            dgvBook.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
            dgvBook.Columns["BookQuantity"].HeaderText = "Số lượng";
            dgvBook.Columns["BookStatus"].HeaderText = "Trạng thái";
            dgvBook.Columns["BookBorrowed"].HeaderText = "Đang mượn";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cmbCategory_SelectedIndexChanged(sender, e);
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBook.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvBook.SelectedRows[0];
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    Book obj = _repoBook.GetById(bookId);

                    frmBookDetails bdetailsForm = new frmBookDetails()
                    {
                        book = obj,
                        role = 0,
                        action = "update"
                    };

                    if (bdetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        frmHomeAdmin_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmBookDetails bdetailsForm = new frmBookDetails()
            {
                role = 0,
                book = new Book(),
                action = "add"
            };

            if (bdetailsForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void waiting_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "waiting",
                title = "Chờ xác nhận",
            };

            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "borrowed",
                title = "Đang trong quá trình mượn sách",
            };

            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void return_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "returned",
                title = "Đã trả sách",
            };

            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void warning_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "warning",
                title = "Quá hạn mượn sách",
            };

            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }

        private void barchart_Click(object sender, EventArgs e)
        {
            frmChart chartForm = new frmChart();

            if (chartForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeAdmin_Load(sender, e);
            }
        }
    }
}
