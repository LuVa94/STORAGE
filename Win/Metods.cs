using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Win
{
    class Metods
    {
        
        public  void Zakypka()
        {
            int num = 0;
            int num_post = 0;
            Random r = new Random();
            int kol = r.Next(100, 170);
            var w = Program.db6.Vivod(0);
            var k = Program.db3.Vivod(0);
            var p = Program.db4.Vivod(0);
            DateTimeOffset a = DateTimeOffset.Now.AddDays(6);
            foreach (Комплектующие kom in k)
            {
                if (kom.Количество < 20)
                {
                    num = kom.комплектующиеID;
                    foreach (Поставщик post in p)
                    {
                        if (post.комплектующиеID == num)
                        {
                            num_post = post.поставщикID;
                            foreach (Закупка zak in w)
                            {
                                if ((zak.комплектующиеID == num) && (DateTimeOffset.Now > zak.Дата_доставки))
                                {
                                    Program.db6.ADD(num_post, num, kol, a);

                                    MessageBox.Show("Созданa заявкa на закупку");
                                }
                                else
                                {
                                    MessageBox.Show("Эта заявка принята поставщиком");
                                }
                            }

                        }

                    }
                }

            }
        }

        public void Dvizhenie()
        {
            int num = 0;
            int kol = 0;
            var w = Program.db6.Vivod(0);
            var k = Program.db3.Vivod(0);
            foreach (Комплектующие kom in k)
            {
                if (kom.Количество < 20)
                {
                    num = kom.комплектующиеID;
                    kol = kom.Количество;
                   
                            foreach (Закупка zak in w)
                            {
                                if ((zak.комплектующиеID == num) && (DateTimeOffset.Now > zak.Дата_доставки))
                                {
                                    kom.Количество =kol+ zak.Количество;
                                }
                            }

                        }

                    }

            }

        public string Vremya()
        {
            var k = Program.db3.Vivod(0);
            string statys = "";
            int ran = 0;
            int r = 0;
            DateTime a;
            foreach (Комплектующие kom in k)
            {
                if (Program.vibormeb == 1)
                {
                    if ((kom.комплектующиеID == 1) && (kom.Количество > 6))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 2) && (kom.Количество > 3))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 3) && (kom.Количество > 6))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 4) && (kom.Количество > 1))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 5) && (kom.Количество > 1))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 6) && (kom.Количество > 1))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 7) && (kom.Количество > 1))
                    {
                        ran += 1;
                    }
                    if ((kom.комплектующиеID == 9) && (kom.Количество > ((kom.Длина * kom.Ширина) / (Program.dlina * Program.shirina) + 1)))
                    {
                        ran += 1;
                    }
                }
                if (ran == 8)
                {
                    statys = "xvataet";
                }
                if (Program.vibormeb != 1)
                {
                    if ((kom.комплектующиеID == 2) && (kom.Количество > 3))
                    {
                        r += 1;
                    }
                    if ((kom.комплектующиеID == 6) && (kom.Количество > 1))
                    {
                        r += 1;
                    }
                    if ((kom.комплектующиеID == 7) && (kom.Количество > 1))
                    {
                        r += 1;
                    }
                    if ((kom.комплектующиеID == 8) && (kom.Количество > 6))
                    {
                        r += 1;
                    }
                    if ((kom.комплектующиеID == 10) && (kom.Количество > ((kom.Длина * kom.Ширина) / (Program.dlina * Program.shirina) + 1)))
                    {
                        r += 1;
                    }
                }
                if (r == 5)
                {
                    statys = "xvataet";
                }

            }
            //здесь для каждого вида мебели свой вид и кол-во комплектующих
            //вычитаем кол-во из склада(из таблицы)
            //если хватает, то поставить статус
            if (statys == "xvataet")
            {
                 a = DateTime.Today.AddDays(10);

            }
            else
            {
                int day = 7 + 10;
                 a = DateTime.Today.AddDays(day);
            }
            return a.ToString();
        }

        public string text = "";

        public string ExtractText(string pathToPdfFile)
        {
            System.IO.FileInfo fiPdf = new FileInfo(pathToPdfFile);

            if (fiPdf.Extension.ToLower() != ".pdf")
                return null;

            PdfReader reader = new PdfReader(pathToPdfFile);

            string txt = string.Empty;
            for (int countPdfPage = 1; countPdfPage <= reader.NumberOfPages; countPdfPage++)
            {
                txt += PdfTextExtractor.GetTextFromPage(reader, countPdfPage, new LocationTextExtractionStrategy());
            }
            text = txt;
            return txt;
        }

        public void Vibor()
        {
            char [] razdelitel = {' ', '\n'};
            string[] words = text.Split(razdelitel);
            string str, str1, str2, str3 = "";
            int N = words.Length;
            List<string> list = new List<string>();
            int M = 0;
            for (int i = 0; i < N; i++)
            {
                if ((words[i] != "")&&(words[i] != "\n"))
                { 
                    list.Add(words[i]);
                    M++;
                }
                
            }
            for (int i = 0; i < M; i++)
            {
                Program.vibmeb = list[1];
                Program.dlina = Convert.ToInt32(list[3]);
                Program.shirina = Convert.ToInt32(list[5]);
                Program.glybina = Convert.ToInt32(list[7]);
                Program.material1 = list[9];
                if (Program.vibmeb != "Shkaf-kype")
                {
                    str2 = list[11];
                    Program.material2 = str2;
                    if (Program.vibmeb == "Tymbochka")
                    {
                        Program.Datetime_vipol = Convert.ToDateTime(list[12]);
                        Program.stoimost = Convert.ToInt32(list[16]);
                        Program.vibdos = list[18];
                        Program.vibdos = list[20];
                    }
                    else
                    {
                        str = list[14];
                        Program.Datetime_vipol = Convert.ToDateTime(str);
                        if (Program.vibmeb != "Shkaf_penal")
                        {
                            if (Program.vibmeb == "Shkaf")
                            {
                                Program.stoimost = Convert.ToInt32(list[17]);
                                Program.vibdos = list[19];
                                Program.vibdos = list[21];
                            }
                            else
                            {
                                Program.stoimost = Convert.ToInt32(list[18]);
                                Program.vibdos = list[20];
                                Program.vibsbor = list[22];
                            }
                        }
                        else
                        {
                            Program.stoimost = Convert.ToInt32(list[17]);
                            Program.vibdos = list[19];
                            Program.vibdos = list[21];
                        }
                    }
                }
                else
                {
                    str3 = list[13];
                    Program.Datetime_vipol = Convert.ToDateTime(str3);
                    Program.stoimost = Convert.ToInt32(list[16]);
                    Program.vibdos = list[18];
                    Program.vibdos = list[20];
                }
                
            }
        }


    }
}
