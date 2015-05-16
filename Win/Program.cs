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
        
        public static void Dat()
        {
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
           // Console.WriteLine(thisDay.ToString());
        }

        public static void Raschet()
        {
            var k=Program.db3.Vivod(0);
            int kol=0;
            string statys = "";
            foreach (Комплектующие kom in k)
            {
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
                    Random r = new Random();
                    int ran = r.Next(1, 7);
                    int day = ran + 10;
                    DateTime a = DateTime.Today.AddDays(day);
                }
            }
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
