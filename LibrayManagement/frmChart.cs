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
using System.Windows.Forms.DataVisualization.Charting;

namespace LibrayManagement
{
    public partial class frmChart : Form
    {
        AccountRepository _repoAcc = new AccountRepository();
        BookRepository _repoBook = new BookRepository();
        CategoryRepository _repoCate = new CategoryRepository();
        HistoryBookRepository _repoHis = new HistoryBookRepository();

        public frmChart()
        {
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            // Tạo danh sách các ngày trong 7 ngày gần nhất
            var dateRange = Enumerable.Range(0, 7)
                                      .Select(i => DateTime.Today - TimeSpan.FromDays(i))
                                      .ToList();
            // Lấy ra số lượng của HistoryStatus là "borrowed" trong 7 ngày gần nhất
            List<Chart> barList = (from date in dateRange
                                   let count = _repoHis.GetAll()
                                                       .Count(his => his.HistoryStatus.Equals("borrowed") && his.HistoryBorrow.HasValue && his.HistoryBorrow.Value.Date == date)
                                   select new Chart
                                   {
                                       key = date.ToString("dd/MM"), // Đặt key là chuỗi ngày tháng
                                       value = count
                                   }).ToList();

            int maxCount = barList.Max(c => c.value);

            // Thiết lập trục tung cho biểu đồ
            ChartBar.ChartAreas[0].AxisY.Maximum = maxCount * 4;
            ChartBar.ChartAreas[0].AxisY.Interval = 2;


            int num = 1;
            foreach (Chart c in barList)
            {
                ChartBar.Series["ChartBar"].Points.Add(new DataPoint(num, c.value) { AxisLabel = c.key });
                num++;
            }

            // ============================ Pie Chart ================================
            // 1. Get all status
            List<string> statusList = (from s in _repoHis.GetAll()
                                       select s.HistoryStatus).Distinct().ToList();

            List<Color> colors = new List<Color> { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Gray };
            int i = 0;
            string sString = "";
            foreach (string str in statusList)
            {
                int count = _repoHis.GetAll().Count(x => x.HistoryStatus.Equals(str));
                ChartPie.Series["ChartPie"].Points.Add(count);

                if (str.Equals("warning")) sString = "Quá hạn";
                if (str.Equals("cancel")) sString = "Đã hủy";
                if (str.Equals("borrowed")) sString = "Đã mượn";
                if (str.Equals("returned")) sString = "Đã trả";
                if (str.Equals("waiting")) sString = "Chờ xác nhận";
                //sString += " - " + count;
                ChartPie.Series["ChartPie"].Points[i].Label = sString;
                
                ChartPie.Series["ChartPie"].Points[i].Color = colors[i];

                i++;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    class Chart
    {
        public string key { get; set; }
        public int value { get; set; }
    }
}
