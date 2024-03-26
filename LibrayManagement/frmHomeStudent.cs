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
using System.Xml.Linq;

namespace LibrayManagement
{
    public partial class frmHomeStudent : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();

        public Account account { get; set; }


        public frmHomeStudent()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmHomeStudent_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> categories = _repoCate.GetAll().Select(cate => cate.CategoryName).ToList();

                categories.Insert(0, "Tất cả");

                cmbCategory.DataSource = categories;
                dgvBook.DataSource = (from book in _repoBook.GetAll().Where(x => x.BookStatus.Equals("on"))
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          book.BookBorrowed
                                      }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                                      where book.BookTitle.ToLower().Contains(search.ToLower()) && book.BookStatus.Equals("on")
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          book.BookBorrowed,
                                      }).ToList();
                dgvBook.Columns["BookId"].HeaderText = "Mã sách";
                dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
                dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
                dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
                dgvBook.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
                dgvBook.Columns["BookQuantity"].HeaderText = "Số lượng";
                dgvBook.Columns["BookBorrowed"].HeaderText = "Đang mượn";
            }
            else
            {
                dgvBook.DataSource = (from book in _repoBook.GetAll()
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      where book.CategoryId == cate.CategoryId && book.BookTitle.ToLower().Contains(search.ToLower()) && book.BookStatus.Equals("on")
                                      select new
                                      {
                                          book.BookId,
                                          book.BookTitle,
                                          category.CategoryName,
                                          book.BookAuthor,
                                          book.BookPublisher,
                                          book.BookQuantity,
                                          book.BookBorrowed
                                      }).ToList();
                dgvBook.Columns["BookId"].HeaderText = "Mã sách";
                dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
                dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
                dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
                dgvBook.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
                dgvBook.Columns["BookQuantity"].HeaderText = "Số lượng";
                dgvBook.Columns["BookBorrowed"].HeaderText = "Đang mượn";
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cmbCategory_SelectedIndexChanged(sender, e);
        }

        private void library_Click(object sender, EventArgs e)
        {
            frmHomeStudent_Load(sender, e);

        }

        private void profile_Click(object sender, EventArgs e)
        {
            frmProfile profileForm = new frmProfile()
            {
                account = account
            };

            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeStudent_Load(sender, e);
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
                frmHomeStudent_Load(sender, e);
            }
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
                        role = 1,
                        action = "view",
                        account = account
                    };

                    if (bdetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        frmHomeStudent_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void waiting_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "waiting",
                title = "Những cuốn sách đang chờ xác nhận"
            };
            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeStudent_Load(sender, e);
            }
        }

        private void borrowed_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "borrowed",
                title = "Những cuốn sách đang mượn"
            };
            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeStudent_Load(sender, e);
            }
        }

        private void returned_Click(object sender, EventArgs e)
        {
            frmStatusBook statusForm = new frmStatusBook()
            {
                account = account,
                status = "returned",
                title = "Những cuốn sách đã trả"
            };
            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                frmHomeStudent_Load(sender, e);
            }
        }
    }
}
