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
        public string Материал
        {
            get;
            set;
        }
        public int Стоимость
        {
            get;
            set;
        }
        public DateTimeOffset Дата_выполнения
        {
            get;
            set;
        }
        public string Статус
        {
            get;
            set;
        }
        public int мебельID
        {
            get;
            set;
        }
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
        private EntityRef<Клиент> kk;
        [Association(Storage = "kk", ThisKey = "заказID", OtherKey = "клиентID",
        IsForeignKey = true)]
        public Клиент Клиент
        {
            get { return kk.Entity; }
            set
            {
                kk.Entity = value;
                if (value != null) клиентID = value.клиентID;
            }
        }
        private EntitySet<Список_заказов> ss = new EntitySet<Список_заказов>();
        [Association(Storage = "ss", OtherKey = "ID")]
        public EntitySet<Список_заказов> Список_заказов
        {
            get { return ss; }
            set { ss.Assign(value); }
        }

        public override string ToString()
        {
            return заказID + " | " + Длина + " | " + Ширина + " | " + Глубина + " | " + Материал + " | " + Стоимость + " | " + Дата_выполнения + " | " + Статус + " | " + мебельID + " | " + клиентID;
        }
       
    }
    public class DB_z : DataContext
    {
        public DB_z(string cs)
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
        public void ADD(int Длина, int Ширина, int Глубина, string Материал, int Стоимость, DateTimeOffset Дата_выполнения, string Статус, int мебельID, int клиентID)
        {
            Заказ z = new Заказ();
            z.Длина = Длина;
            z.Ширина = Ширина;
            z.Глубина = Глубина;
            z.Материал= Материал;
            z.Стоимость = Стоимость;
            z.Дата_выполнения = Дата_выполнения;
            z.Статус = Статус;
            z.мебельID = мебельID;
            z.клиентID = клиентID;
            this.Заказ.InsertOnSubmit(z);
            this.SubmitChanges();
        }

        public void Edit(int заказID, int Длина, int Ширина, int Глубина, string Материал, int Стоимость, DateTimeOffset Дата_выполнения, string Статус, int мебельID, int клиентID)
        {
            Заказ z = this.Заказ.Where(c => c.заказID == заказID).FirstOrDefault();
            z.Длина = Длина;
            z.Ширина = Ширина;
            z.Глубина = Глубина;
            z.Материал = Материал;
            z.Стоимость = Стоимость;
            z.Дата_выполнения = Дата_выполнения;
            z.Статус = Статус;
            z.мебельID = мебельID;
            z.клиентID = клиентID;
            this.SubmitChanges();
        }

        public void Delete(int заказID)
        {
            Заказ z = this.Заказ.Where(c => c.заказID == заказID).FirstOrDefault();
            this.Заказ.DeleteOnSubmit(z);
            this.SubmitChanges();
        }
        public List<Заказ> Vivod(int заказID)
        {
            return this.Заказ.Select(c => c).ToList();
        }
    }
}


