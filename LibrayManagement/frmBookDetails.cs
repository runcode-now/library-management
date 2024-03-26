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
    public partial class frmBookDetails : Form
    {
        public string action { get; set; }

        public Book book { get; set; }

        public int role { get; set; }

        public Account account { get; set; }

        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();
        HistoryBookRepository _repoHis = new HistoryBookRepository();

        public frmBookDetails()
        {
            InitializeComponent();
        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {

            cmbCategory.DataSource = (from c in _repoCate.GetAll()
                                      select c.CategoryName).ToList();
            cmbCategory.SelectedIndex = 0;

            // check action
            if (action.Equals("view") || action.Equals("update"))
            {
                Category cate = _repoCate.GetById(book.CategoryId.Value);

                txtBookId.Text = book.BookId.ToString();
                txtName.Text = book.BookTitle.ToString();
                txtAuthor.Text = book.BookAuthor.ToString();
                txtPublisher.Text = book.BookPublisher.ToString();
                numQuantity.Text = book.BookQuantity.ToString();
                txtBorrowed.Text = book.BookBorrowed.ToString();
                txtDescription.Text = book.BookDescription.ToString();

                int index = cmbCategory.FindStringExact(cate.CategoryName);
                if (index != -1)
                    // Nếu index hợp lệ, chọn mục tại index
                    cmbCategory.SelectedIndex = index;

                // choose status
                string status = book.BookStatus.ToString();
                if (status.Equals("off")) rdoOff.Checked = true;
                else rdoOn.Checked = true;

            }
            else  // action add
            {
                btnUpdate.Visible = btnCancel.Visible = btnDelete.Visible = false;
                txtBookId.Text = "0";
                txtName.Text = "";
                txtAuthor.Text = "";
                txtPublisher.Text = "";
                numQuantity.Text = "";
                txtBorrowed.Text = "";
                txtDescription.Text = "";
                rdoOn.Checked = true;
                btnAdd.Visible = true;
                btnRefresh.Visible = true;
            }

            // load image
            if (book != null && book.BookImage != null)
            {
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
            }

            //Student(User)
            if (role == 1)
            {
                lbReturn.Visible = dtpReturn.Visible = true;
                btnAdd.Visible = btnUpdate.Visible = btnDelete.Visible = lbStatus.Visible = rdoOn.Visible = rdoOff.Visible = false;
                cmbCategory.Enabled = txtName.Enabled = txtAuthor.Enabled = txtPublisher.Enabled = numQuantity.Enabled = txtDescription.Enabled = txtBorrowed.Enabled = false;

                // check when the quantity <= borrowed
                if (book.BookQuantity == book.BookBorrowed)
                    btnBorrow.Enabled = false;

                HistoryBook h = _repoHis.CheckExit(book.BookId, account.AccountId);
                if (h != null)   // each person just borrow 1 book in (waiting or borrowed)
                {
                    btnBorrow.Enabled = false;
                    btnCancel.Enabled = true;
                }
                else
                {
                    btnBorrow.Enabled = true;
                    btnCancel.Enabled = false;
                }


            }
            else    // Admin (Manager)
            {
                btnBorrow.Visible = btnCancel.Visible = false;
            }
        }

        private void pboxBook_Click(object sender, EventArgs e)
        {
            // authorization
            if (role == 0)
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

                        book.BookImage = imageData;

                        // Lưu imageData vào cơ sở dữ liệu
                        if (action.Equals("update"))
                            _repoBook.Update(book);

                        frmBookDetails_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HistoryBook hisbook = _repoHis.GetAll().FirstOrDefault(x => x.BookId == book.BookId);
            if (hisbook != null)
            {
                MessageBox.Show("Không thể xóa vì đang có người mượn");
                return;
            }


            _repoBook.Delete(book.BookId);
            MessageBox.Show("Xóa sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check quantity
            int quantity = 0;
            try
            {
                quantity = int.Parse(numQuantity.Text);
                if (quantity <= 0) throw new Exception("Số lượng sách phải là số nguyên dương và lớn hơn 0!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            book.BookTitle = txtName.Text;
            book.BookAuthor = txtAuthor.Text;
            book.BookPublisher = txtPublisher.Text;
            book.BookQuantity = quantity;
            book.BookDescription = txtDescription.Text;

            if (rdoOn.Checked) book.BookStatus = "on";
            else book.BookStatus = "off";

            Category cate = _repoCate.GetByName(cmbCategory.Text);
            book.CategoryId = cate.CategoryId;

            _repoBook.Update(book);
            MessageBox.Show("Cập nhật thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check condition
            // image
            if (book.BookImage == null)
            {
                MessageBox.Show("Hãy chọn ảnh cho cuốn sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // quantity
            int quantity = 0;
            try
            {
                quantity = int.Parse(numQuantity.Text);
                if (quantity <= 0) throw new Exception("Số lượng sách phải là số nguyên dương và lớn hơn 0!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            book.BookTitle = txtName.Text;
            book.BookAuthor = txtAuthor.Text;
            book.BookPublisher = txtPublisher.Text;
            book.BookQuantity = quantity;
            book.BookDescription = txtDescription.Text;
            book.BookBorrowed = 0;

            if (rdoOn.Checked) book.BookStatus = "on";
            else book.BookStatus = "off";

            Category cate = _repoCate.GetByName(cmbCategory.Text);
            book.CategoryId = cate.CategoryId;

            _repoBook.Create(book);
            MessageBox.Show("Thêm sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBookDetails_Load(sender, e);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // validate time return
            DateTime date = DateTime.Parse(dtpReturn.Text);
            TimeSpan time = date.Subtract(DateTime.Now);
            if (date < DateTime.Now)
            {
                MessageBox.Show("Thời gian trả sách không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (time.TotalDays > 14)       // check time
            {
                MessageBox.Show("Bạn chỉ được mượn cuốn sách tối đa trong vòng 14 ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HistoryBook his = new HistoryBook()
            {
                HistoryReturn = DateTime.Parse(dtpReturn.Text),
                HistoryStatus = "waiting",
                BookId = book.BookId,
                AccountId = account.AccountId
            };

            _repoHis.Create(his);

            book.BookBorrowed += 1;
            _repoBook.Update(book);
            MessageBox.Show("Đã gửi yêu cầu mượn sách !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmBookDetails_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HistoryBook h = _repoHis.CheckExit(book.BookId, account.AccountId);
            if (h != null)   // each person just borrow 1 book in (waiting)
            {
                h.HistoryStatus = "cancel";
            }
            _repoHis.Update(h);

            book.BookBorrowed -= 1;
            _repoBook.Update(book);
            MessageBox.Show("Hủy mượn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmBookDetails_Load(sender, e);

        }
    }
}
