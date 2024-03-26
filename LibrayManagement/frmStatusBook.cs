using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrayManagement
{
    public partial class frmStatusBook : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();
        HistoryBookRepository _repoHis = new HistoryBookRepository();
        List<string> emailList = null;

        public Account account { get; set; }

        public string status { get; set; }

        public string title { get; set; }


        public frmStatusBook()
        {
            InitializeComponent();
        }

        private void frmStatusBook_Load(object sender, EventArgs e)
        {
            // Customer
            if (account.AccountRole == 1) LoadDateCustomer();

            // Admin
            else LoadDateAdmin();


        }

        private void LoadDateCustomer()
        {
            lbTitle.Text = title;
            dgvBook.DataSource = (from his in _repoHis.GetAll()
                                  join book in _repoBook.GetAll() on his.BookId equals book.BookId
                                  join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                  where his.AccountId == account.AccountId & his.HistoryStatus.Equals(status)
                                  select new
                                  {
                                      book.BookId,
                                      book.BookTitle,
                                      category.CategoryName,
                                      book.BookAuthor,
                                      book.BookPublisher,
                                      book.BookQuantity,
                                      book.BookBorrowed,
                                      HistoryDate = status == "waiting" || status == "borrowed" ? his.HistoryReturn : his.HistoryActual
                                  }).ToList();
            dgvBook.Columns["BookId"].HeaderText = "Mã sách";
            dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
            dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
            dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
            dgvBook.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
            dgvBook.Columns["BookQuantity"].HeaderText = "Số lượng";
            dgvBook.Columns["BookBorrowed"].HeaderText = "Đã mượn";
            if (status.Equals("waiting") || status.Equals("borrowed")){
                dgvBook.Columns["HistoryDate"].HeaderText = "Ngày trả sách dự kiến";
            }
            else
            {
                dgvBook.Columns["HistoryDate"].HeaderText = "Ngày trả sách";
            }
        }

        private void LoadDateAdmin()
        {
            lbTitle.Text = title;
            if (!status.Equals("warning"))
            {
                dgvBook.DataSource = (from acc in _repoAcc.GetAll()
                                      join his in _repoHis.GetAll() on acc.AccountId equals his.AccountId
                                      join book in _repoBook.GetAll() on his.BookId equals book.BookId
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      where his.HistoryStatus.Equals(status)
                                      select new
                                      {
                                          his.HistoryId,
                                          acc.AccountName,
                                          book.BookId,
                                          book.BookTitle,
                                          book.BookAuthor,
                                          category.CategoryName,
                                          HistoryDate = status == "waiting" || status == "borrowed" ? his.HistoryReturn : his.HistoryActual
                                      }).ToList();
                dgvBook.Columns["HistoryId"].HeaderText = "Mã lịch sử";
                dgvBook.Columns["AccountName"].HeaderText = "Họ tên";
                dgvBook.Columns["BookId"].HeaderText = "Mã sách";
                dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
                dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
                dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
                if (status.Equals("waiting") || status.Equals("borrowed"))
                {
                    dgvBook.Columns["HistoryDate"].HeaderText = "Ngày trả sách dự kiến";
                }
                else
                {
                    dgvBook.Columns["HistoryDate"].HeaderText = "Ngày trả sách";
                }
            }
            if (status.Equals("warning"))
            {
                dgvBook.DataSource = (from acc in _repoAcc.GetAll()
                                      join his in _repoHis.GetAll() on acc.AccountId equals his.AccountId
                                      join book in _repoBook.GetAll() on his.BookId equals book.BookId
                                      join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                                      where his.HistoryStatus.Equals(status)
                                      // &&  his.HistoryReturn < DateTime.Now
                                      // orderby (status != null ? his.BookId : null)
                                      select new
                                      {
                                          his.HistoryId,
                                          acc.AccountName,
                                          book.BookId,
                                          book.BookTitle,
                                          book.BookAuthor,
                                          category.CategoryName,
                                          his.HistoryBorrow,
                                          his.HistoryReturn
                                      }).ToList();

                // var query = query.OrderBy(item => item.BookId);
                dgvBook.Columns["HistoryId"].HeaderText = "Mã lịch sử";
                dgvBook.Columns["AccountName"].HeaderText = "Họ tên";
                dgvBook.Columns["BookId"].HeaderText = "Mã sách";
                dgvBook.Columns["BookTitle"].HeaderText = "Tên sách";
                dgvBook.Columns["BookAuthor"].HeaderText = "Tác giả";
                dgvBook.Columns["CategoryName"].HeaderText = "Thể loại";
                dgvBook.Columns["HistoryBorrow"].HeaderText = "Ngày mượn sách";
                dgvBook.Columns["HistoryReturn"].HeaderText = "Ngày trả sách dự kiến";


                // initialize email list
                emailList = new List<string>();
                emailList = (from acc in _repoAcc.GetAll()
                             join his in _repoHis.GetAll() on acc.AccountId equals his.AccountId
                             join book in _repoBook.GetAll() on his.BookId equals book.BookId
                             join category in _repoCate.GetAll() on book.CategoryId equals category.CategoryId
                             where his.HistoryStatus.Equals(status)
                             //where his.HistoryReturn < DateTime.Now
                             select acc.AccountEmail).Distinct().ToList();

                if(emailList != null && emailList.Count != 0) linkWarning.Visible = true;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            if (account.AccountRole == 0)
            {

                try
                {
                    if (dgvBook.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dgvBook.SelectedRows[0];
                        int hisId = Convert.ToInt32(row.Cells["HistoryId"].Value);
                        HistoryBook obj = _repoHis.GetById(hisId);

                        frmHistoryDetails historyForm = new frmHistoryDetails()
                        {
                            history = obj,
                            status = status
                        };

                        if (historyForm.ShowDialog() == DialogResult.OK)
                        {
                            frmStatusBook_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void linkWarning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn gửi mail nhắc nhở không? Quá trình gửi mail có thể mất vài phút", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                string from = "anhphhe172226@fpt.edu.vn";
                string pass = "uejfafkbigxahvnd";
                string content = "Bạn đã quá thời hạn mượn sách của thư viện. Vui lòng trả sách theo đúng thời hạn!";

                foreach (string to in emailList)
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(to);
                    mail.From = new MailAddress(from);
                    mail.Subject = "Thông báo về việc trả sách.";
                    mail.Body = content;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(mail);
                        MessageBox.Show("Gửi thông báo thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                return;
        }
    }
}
