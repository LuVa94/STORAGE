using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static DB_meb db1 = new DB_meb(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_kl db2 = new DB_kl(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_com db3 = new DB_com(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_post db4 = new DB_post(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_sost db5 = new DB_sost(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_zak db6 = new DB_zak(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        public static DB_zakaz db7 = new DB_zakaz(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");

        // переменные для конструктора мебели
        public static int vibormeb = 0;
        public static int dlina = 0;
        public static int shirina = 0;
        public static int glybina = 0;
        public static string material1 = "";
        public static string material2 = "";
        public static int stoimost = 0;
        public static DateTimeOffset Datetime_vipol;



        public static void Raschet()
        {
            var k=Program.db3.Vivod(0);
            string statys = "";
            int ran = 0;
            //foreach (Комплектующие kom in k)
            //{
                //здесь для каждого вида мебели свой вид и кол-во комплектующих
                //вычитаем кол-во из склада(из таблицы)
                //если хватает, то поставить статус
                if(statys=="xvataet")
                {
                   // DateTime thisDay = DateTime.Today;
                    DateTime a = DateTime.Today.AddDays(10);

                }
                else
                {
                    //проход по списку комплектующих и выделение id для подсчета времени
                    var z = Program.db6.Vivod(0);
                    foreach (Закупка zak in z)
                    {
                        DateTime d1 = DateTime.Today;
                        DateTimeOffset d2 = zak.Дата_доставки;
                        TimeSpan time = d2 - d1;
                        ran = Convert.ToInt32(time);
                    }
                    
                    int day = ran + 10;
                    DateTime a = DateTime.Today.AddDays(day);
                }
            //}
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
