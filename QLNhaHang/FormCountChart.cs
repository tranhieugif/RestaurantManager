using Microsoft.EntityFrameworkCore;
using QLNhaHang.DTO;
using QLNhaHang.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QLNhaHang
{
    public partial class FormCountChart : Form
    {
        public FormCountChart()
        {
            InitializeComponent();
            loadChart();
        }
        void loadChart()
        {
            Controls.Clear();

            chartMonthly.Series.Clear();

            var db = new RestaurantDB();

            var result = db.Bills
                .Where(b => b.Status == 1)
                .GroupBy(b => EF.Property<DateTime>(b, "DateCheckOut").Date)
                .Select(g => new
                {
                    DateCheckOut = g.Key,
                    Total = g.Sum(b => b.TotalPrice)
                })
                .ToList();


            // Tạo loại biểu đồ
            Series series = new Series("Doanh thu theo ngày");

            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in result)
            {
                // Thêm dữ liệu vào loại biểu đồ
                series.Points.AddXY(item.DateCheckOut, item.Total);
            }

            // Thêm loại biểu đồ vào biểu đồ
            chartMonthly.Series.Add(series);
            chartMonthly.Invalidate();

            // Thêm biểu đồ vào form
            Controls.Add(chartMonthly);

        }
    }
}
