using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win
{
    class PriceCalculator
    {
        public decimal Price { get; set; }
        public List<Комплектующие> Complects { get; set; }

        //Шкаф-купе
        public void CalculateShkafKupe(int model, int polkiLevo, int polkiVerh, int oformlenie, decimal width, decimal height, decimal length, string materialName)
        {
            decimal square = 0;
            Price = 0;
            Complects = new List<Комплектующие>();

            width /= 1000;
            height /= 1000;
            length /= 1000;
            var mirror = Program.db5.Материал.FirstOrDefault(m => m.материалID == 11);
            var material = Program.db5.Материал.FirstOrDefault(m => m.Название == materialName);

            if (model == 1 || model == 2)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length + height * length;

                square += polkiLevo * width * length / 3;
                square += polkiVerh * height * length / 4;


                // Добавить в материалы цену за квадратный метр и использовать цену вместо 1000
                // matrial
                Price += square * 1000;

                // Добавить в материалы цену ща квадратный метр и использовать цену вместо 2000
                if (oformlenie == 1)
                {
                    // mirror
                    Price += width * height * 2000;
                }

                // Добавить в материалы цену ща квадратный метр и использовать цену вместо 2000 и 1000
                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * 2000 / 3;
                    // matrial
                    Price += 2 * width * height * 1000 / 3;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * 1000;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);

                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
            }

            if (model == 3)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length + 2 * height * length;

                square += 2 * polkiLevo * width * length / 5;
                square += polkiVerh * height * length / 5;


                // Добавить в материалы цену за квадратный метр и использовать цену вместо 1000
                // matrial
                Price += square * 1000;

                // Добавить в материалы цену ща квадратный метр и использовать цену вместо 2000
                if (oformlenie == 1)
                {
                    // mirror
                    Price += width * height * 2000;
                }

                // Добавить в материалы цену за квадратный метр и использовать цену вместо 2000 и 1000
                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * 2000 / 3;
                    // matrial
                    Price += 2 * width * height * 1000 / 3;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * 1000;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);

                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
            }
            if (model == 4 || model == 5)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length + 2 * height * length;

                square += polkiLevo * width * length / 5 * 2;
                square += polkiVerh * height * length / 5;

                Price += square * 1000;

                if (oformlenie == 1)
                {
                    // mirror
                    Price += width * height * 2000;
                }

                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * 2000 / 3;
                    // matrial
                    Price += 2 * width * height * 1000 / 3;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * 1000;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);

                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
            }
            if (model == 6)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length + 4 * height * length;

                square += polkiLevo * width * length / 8 * 4;
                square += polkiVerh * height * length / 5;

                Price += square * 1000;

                if (oformlenie == 1)
                {
                    // mirror
                    Price += width * height * 2000;
                }

                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * 2000 / 3;
                    // matrial
                    Price += 2 * width * height * 1000 / 3;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * 1000;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);

                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
            }

        }
    //Шкаф-пенал
        public void CalculateShkafPenal(int model, int polki, int oformlenie, decimal width, decimal height, decimal length, string materialName, string materialName1)
        {
            decimal square = 0;
            Price = 0;
            Complects = new List<Комплектующие>();

            width /= 1000;
            height /= 1000;
            length /= 1000;
            var mirror = Program.db5.Материал.FirstOrDefault(m => m.материалID == 11);
            var material = Program.db5.Материал.FirstOrDefault(m => m.Название == materialName);
            var material1 = Program.db5.Материал.FirstOrDefault(m => m.Название == materialName1);

            //Цена за квадратный метр
            var cost = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
            Complects.Add(cost);
            var cost1 = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 15);
            Complects.Add(cost1);
           

            if (model == 1)
            {
                square = 2 * width * length + 2 * width * length;
                square += polki * width * length;

                //Цена за квадратный метр = 1000
                Price += square * cost.Стоимость;

                // Зеркало: цена за квадратный метр и использовать цену вместо 2000

                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * cost1.Стоимость;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 4)
                {
                    // matrial
                    Price += width * height * cost.Стоимость*3;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);
                var bolti = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 6);
                Complects.Add(bolti);
                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);
                var ruchka = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 8);
                Complects.Add(ruchka);
                var dvp = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
                Complects.Add(ruchka);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
                Price += bolti.Стоимость;
                Price += ruchka.Стоимость;
                Price += dvp.Стоимость;
            }
            if (model == 2)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length;

                square += polki * width * length;

                //Цена за квадратный метр = 1000
                Price += square * cost.Стоимость;

                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * cost1.Стоимость;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 4)
                {
                    // matrial
                    Price += width * height * cost.Стоимость * 3;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);
                var bolti = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 6);
                Complects.Add(bolti);
                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);
                var ruchka = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 8);
                Complects.Add(ruchka);
                var dvp = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
                Complects.Add(ruchka);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
                Price += bolti.Стоимость;
                Price += ruchka.Стоимость;
                Price += dvp.Стоимость;
            }
            if ((model == 3) || (model == 4))
            {
                square = 2 * width * length + 2 * width * length;
                square += width * length;

                square += polki * width * length;

                //Цена за квадратный метр = 1000
                Price += square * cost.Стоимость;

                if (oformlenie == 2)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * cost1.Стоимость;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 4)
                {
                    // matrial
                    Price += width * height * cost.Стоимость * 3;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);
                var bolti = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 6);
                Complects.Add(bolti);
                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);
                var ruchka = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 8);
                Complects.Add(ruchka);
                var dvp = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
                Complects.Add(ruchka);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
                Price += bolti.Стоимость;
                Price += ruchka.Стоимость;
                Price += dvp.Стоимость;
            }
            if (model == 5)
            {
                square = 2 * width * length + 2 * width * length;
                square += 2 * width * length;

                square += polki * width * length;

                //Цена за квадратный метр = 1000
                Price += square * cost.Стоимость;

                if (oformlenie == 2)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * cost1.Стоимость;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 4)
                {
                    // matrial
                    Price += width * height * cost.Стоимость * 3;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);
                var bolti = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 6);
                Complects.Add(bolti);
                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);
                var ruchka = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 8);
                Complects.Add(ruchka);
                var dvp = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
                Complects.Add(ruchka);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
                Price += bolti.Стоимость;
                Price += ruchka.Стоимость;
                Price += dvp.Стоимость;
            }
            if (model == 6)
            {
                square = 2 * width * length + 2 * width * length;
                square += 3 * width * length;

                square += polki * width * length;

                //Цена за квадратный метр = 1000
                Price += square * cost.Стоимость;

                if (oformlenie == 2)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 2)
                {
                    // mirror
                    Price += width * height * cost1.Стоимость;
                }

                if (oformlenie == 3)
                {
                    // matrial
                    Price += width * height * cost.Стоимость;
                }
                if (oformlenie == 4)
                {
                    // matrial
                    Price += width * height * cost.Стоимость * 3;
                }

                var nails = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 7);
                Complects.Add(nails);
                var bolti = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 6);
                Complects.Add(bolti);
                var panel = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 2);
                Complects.Add(panel);
                var ruchka = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 8);
                Complects.Add(ruchka);
                var dvp = Program.db3.Комплектующие.FirstOrDefault(n => n.комплектующиеID == 9);
                Complects.Add(ruchka);

                Price += nails.Стоимость;
                Price += panel.Стоимость;
                Price += bolti.Стоимость;
                Price += ruchka.Стоимость;
                Price += dvp.Стоимость;
            }
        }
    }
}
