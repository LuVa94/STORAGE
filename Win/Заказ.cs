using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;


namespace Win
{
    [Table]
    public class Заказ
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int заказID
        {
            get;
            set;
        }
        [Column]
        public int Длина
        {
            get;
            set;
        }
        [Column]
        public int Ширина
        {
            get;
            set;
        }
        [Column]
        public int Глубина
        {
            get;
            set;
        }
        [Column]
        public int Стоимость
        {
            get;
            set;
        }
        [Column]
        public DateTimeOffset Дата_выполнения
        {
            get;
            set;
        }
        [Column]
        public string Статус
        {
            get;
            set;
        }
        [Column]
        public int мебельID
        {
            get;
            set;
        }
        [Column]
        public int клиентID
        {
            get;
            set;
        }

        private EntityRef<Мебель> mm;
        [Association(Storage = "mm", ThisKey = "заказID", OtherKey = "мебельID",
        IsForeignKey = true)]
        public Мебель Мебель
        {
            get { return mm.Entity; }
            set
            {
                mm.Entity = value;
                if (value != null) мебельID = value.мебельID;
            }
        }
       
        private EntityRef<Клиент> pop;
        [Association(Storage = "pop", ThisKey = "заказID", OtherKey = "клиентID",
        IsForeignKey = true)]
        public Клиент Клиент
        {
            get { return pop.Entity; }
            set
            {
                pop.Entity = value;
                if (value != null) клиентID = value.клиентID;
            }
        }

        public override string ToString()
        {
            return заказID + " | " + Длина + " | " + Ширина + " | " + Глубина + " | " + Стоимость + " | " + Дата_выполнения + " | " + Статус + " | " + мебельID + " | " + клиентID;
        }
       
    }
    public class DB_zakaz : DataContext
    {
        public DB_zakaz(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Заказ> Заказ
        {
            get { return this.GetTable<Заказ>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(int Длина, int Ширина, int Глубина, int Стоимость, DateTimeOffset Дата_выполнения, string Статус, int мебельID, int клиентID)
        {
            Заказ za = new Заказ();
            za.Длина = Длина;
            za.Ширина = Ширина;
            za.Глубина = Глубина;
            za.Стоимость = Стоимость;
            za.Дата_выполнения = Дата_выполнения;
            za.Статус = Статус;
            za.мебельID = мебельID;
            za.клиентID = клиентID;
            this.Заказ.InsertOnSubmit(za);
            this.SubmitChanges();
        }

        public void Edit(int заказID, int Длина, int Ширина, int Глубина, int Стоимость, DateTimeOffset Дата_выполнения, string Статус, int мебельID, int клиентID)
        {
            Заказ za = this.Заказ.Where(c => c.заказID == заказID).FirstOrDefault();
            za.Длина = Длина;
            za.Ширина = Ширина;
            za.Глубина = Глубина;
            za.Стоимость = Стоимость;
            za.Дата_выполнения = Дата_выполнения;
            za.Статус = Статус;
            za.мебельID = мебельID;
            za.клиентID = клиентID;
            this.SubmitChanges();
        }

        public void Delete(int заказID)
        {
            Заказ za = this.Заказ.Where(c => c.заказID == заказID).FirstOrDefault();
            this.Заказ.DeleteOnSubmit(za);
            this.SubmitChanges();
        }
        public List<Заказ> Vivod(int заказID)
        {
            Заказ za = this.Заказ.Where(c => c.заказID > заказID).FirstOrDefault();
            return this.Заказ.Where(c => c.заказID>заказID).ToList<Заказ>();
        }
    }
}


