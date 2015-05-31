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
    public partial class TableForm : Form
    {
        public TableForm()
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
            var ws = file.Worksheets[0];

            // В гриде удаляем все столбцы и строки
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            // Массив заголовков. Проходимся по нему
            var headers = new[] { "Период", "Кол-во заказов", "Сумма заказов", "Прибыль", "Прибыль за заказ" };
            for (int i = 0; i < headers.Length; i++)
            {
                // Создаём столбец в гриде с именем headers[i]
                dataGrid.Columns.Add(headers[i], headers[i]);

                // В Excel в 0 строку i столбец записываем значение заголовка
                ws.Cells[0, i].Value = headers[i];
            }

            var dates = GetDates(dateFrom, dateTo);

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
                int profitPerSale = 0;
                if (dateSales.Count != 0)
                {
                    profitPerSale = profit / dateSales.Count;
                }

                // В грид добавляем строку и заполняем данными
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = name;
                dataGrid.Rows[i].Cells[1].Value = dateSales.Count.ToString();
                dataGrid.Rows[i].Cells[2].Value = sum + " руб.";
                dataGrid.Rows[i].Cells[3].Value = profit + " руб.";
                dataGrid.Rows[i].Cells[4].Value = profitPerSale + " руб.";

                // В Excel заполняем i + 1 строку 
                ws.Cells[i + 1, 0].Value = name;
                ws.Cells[i + 1, 1].Value = dateSales.Count.ToString();
                ws.Cells[i + 1, 2].Value = sum + " руб.";
                ws.Cells[i + 1, 3].Value = profit + " руб.";
                ws.Cells[i + 1, 4].Value = profitPerSale + " руб.";
            }

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
