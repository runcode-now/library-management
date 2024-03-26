namespace LibrayManagement
{
    partial class frmChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            ChartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnClose = new Button();
            ChartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ChartBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartPie).BeginInit();
            SuspendLayout();
            // 
            // ChartBar
            // 
            chartArea1.Name = "ChartArea1";
            ChartBar.ChartAreas.Add(chartArea1);
            ChartBar.Dock = DockStyle.Left;
            legend1.Name = "Legend1";
            ChartBar.Legends.Add(legend1);
            ChartBar.Location = new Point(0, 0);
            ChartBar.Name = "ChartBar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng mượn";
            series1.Name = "ChartBar";
            ChartBar.Series.Add(series1);
            ChartBar.Size = new Size(850, 582);
            ChartBar.TabIndex = 0;
            ChartBar.Text = "chart1";
            title1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title1.ForeColor = Color.DarkGreen;
            title1.Name = "Title1";
            title1.Text = "Thống kê số lượng yêu cầu mượn sách theo ngày";
            ChartBar.Titles.Add(title1);
            // 
            // btnClose
            // 
            btnClose.Location = new Point(747, 547);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ChartPie
            // 
            chartArea2.Name = "ChartArea1";
            ChartPie.ChartAreas.Add(chartArea2);
            ChartPie.Dock = DockStyle.Right;
            legend2.Name = "Legend1";
            ChartPie.Legends.Add(legend2);
            ChartPie.Location = new Point(845, 0);
            ChartPie.Name = "ChartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "ChartPie";
            ChartPie.Series.Add(series2);
            ChartPie.Size = new Size(449, 582);
            ChartPie.TabIndex = 3;
            ChartPie.Text = "chart1";
            title2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title2.ForeColor = Color.DarkGreen;
            title2.Name = "Title1";
            title2.Text = "Tỉ lệ trạng thái các lần mượn sách";
            ChartPie.Titles.Add(title2);
            // 
            // frmChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 582);
            Controls.Add(ChartPie);
            Controls.Add(btnClose);
            Controls.Add(ChartBar);
            Name = "frmChart";
            Text = "frmChart";
            Load += frmChart_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartPie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBar;
        private Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPie;
    }
}