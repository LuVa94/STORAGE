using GemBox.Spreadsheet;
using GemBox.Spreadsheet.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Win
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();

            int date = DateTime.Now.Day;
            dtpFrom.Value = DateTime.Now.Date.AddDays(1 - date);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Дата 'по' должна быть >= даты 'с'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                MakeReport(dialog.FileName, dtpFrom.Value.Date, dtpTo.Value.Date.AddDays(1));
            }
        }

        private void MakeReport(string fileName, DateTime dateFrom, DateTime dateTo)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var file = new ExcelFile();
            file.Worksheets.Add("График прибыли");
            var wsChart = file.Worksheets[0];

            var dates = GetDates(dateFrom, dateTo);

            chart1.Series.Clear();
            chart1.Series.Add("Прибыль");
            chart1.Series.Add("Продажи");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[1].ChartType = SeriesChartType.Column;

            wsChart.Cells[1, 0].Value = "Прибыль";
            wsChart.Cells[2, 0].Value = "Продажи";

            var sales = Program.db7.Заказ.Where(s => dateFrom <= s.Дата_выполнения && s.Дата_выполнения < dateTo).ToList();
            for(int i = 0; i < dates.Count - 1; i++)
            {
                var dFrom = dates[i];
                var dTo = dates[i + 1];

                var dateSales = sales.Where(s => dFrom <= s.Дата_выполнения && s.Дата_выполнения < dTo).ToList();
                int sum = 0;
                int profit = 0;

                if (dateSales.Count > 0)
                {
                    sum = dateSales.Sum(s => s.Стоимость);
                    profit = sum / 4;
                }

                string name = (i + 1) + ". " + dFrom.ToShortDateString() + " - " + dTo.ToShortDateString() ;
                chart1.Series[0].Points.AddXY(name, profit);
                chart1.Series[1].Points.AddXY(name, sum);
                
                wsChart.Cells[0, i + 1].Value = name;
                wsChart.Cells[0, i + 1].Style.Font.Italic = true;
                wsChart.Cells[1, i + 1].Value = profit;
                wsChart.Cells[2, i + 1].Value = sum;
                wsChart.Columns[i + 1].AutoFit();
            }

            // Create chart and select data for it.
            var chart = (ColumnChart)wsChart.Charts.Add(ChartType.Column, "A4", 1024, 360, LengthUnit.Pixel);
            chart.SelectData(wsChart.Cells.GetSubrangeAbsolute(0, 0, 2, dates.Count - 1));
         
            // Set chart title.
            chart.Title.Text = "График прибыли";

            // For all charts (except Pie and Bar) value axis is vertical.
            var valueAxis = chart.Axes.VerticalValue;

            // Set value axis scaling, units, gridlines and tick marks.
            valueAxis.MajorGridlines.IsVisible = true;
            valueAxis.MinorGridlines.IsVisible = true;
            valueAxis.MajorTickMarkType = TickMarkType.Outside;
            valueAxis.MinorTickMarkType = TickMarkType.Cross;

            // Make entire sheet print horizontally centered on a single page with headings and gridlines.
            var printOptions = wsChart.PrintOptions;
            printOptions.HorizontalCentered = printOptions.PrintHeadings = printOptions.PrintGridlines = true;
            printOptions.FitWorksheetWidthToPages = printOptions.FitWorksheetHeightToPages = 1;             

            file.Save(fileName);
            Process.Start(fileName);
        }

        // Получаем список дат, между которыми будет идти срез
        // Например мы указали с 15.05 по 15.07, тогда данный список будет содержать даты
        // 15.05, 1.06, 1.07, 15.07
        private List<DateTime> GetDates(DateTime dateFrom, DateTime dateTo)
        {
            // Список дат, куда мы добавляем начальную дату
            var dates = new List<DateTime>();
            dates.Add(dateFrom);

            // Далее мы берём первую дату следующего месяца
            var nextDate = NextMonthDate(dateFrom);

            // Пока она меньше чем dateTo
            while (nextDate < dateTo)
            {
                // Добавляем её в спиок и находим следующую дату
                dates.Add(nextDate);
                nextDate = NextMonthDate(nextDate);
            }

            // Добавляем dateTob и возвращаем список
            dates.Add(dateTo);
            return dates;
        }

        // Берём первую дату следующего месяца
        private DateTime NextMonthDate(DateTime date)
        {
            // Например дата 20.05. Берём кол-во дней 20.
            // Отнимаем от даты 19 дней и прибавляем 1 месяц
            // Получаетя 1.06
            int days = date.Day;
            return date.Date.AddDays(1 - days).AddMonths(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
