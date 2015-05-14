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
        public static DB_szak db8 = new DB_szak(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
    

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
