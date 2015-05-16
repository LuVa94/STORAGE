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
    public class Закупка
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int закупкаID
        {
            get;
            set;
        }
        [Column]
        public int поставщикID
        {
            get;
            set;
        }
        [Column]
        public int комплектующиеID
        {
            get;
            set;
        }
        [Column]
        public int Количество
        {
            get;
            set;
        }
        [Column]
        public DateTimeOffset Дата_доставки
        {
            get;
            set;
        }

        private EntityRef<Поставщик> ppp;
        [Association(Storage = "ppp", ThisKey = "закупкаID", OtherKey = "поставщикID",
        IsForeignKey = true)]
        public Поставщик Поставщик
        {
            get { return ppp.Entity; }
            set
            {
                ppp.Entity = value;
                if (value != null) поставщикID = value.поставщикID;
            }
        }
        private EntityRef<Комплектующие> kkk;
        [Association(Storage = "kkk", ThisKey = "закупкаID", OtherKey = "комплектующиеID",
        IsForeignKey = true)]
        public Комплектующие Комплектующие
        {
            get { return kkk.Entity; }
            set
            {
                kkk.Entity = value;
                if (value != null) комплектующиеID = value.комплектующиеID;
            }
        }

        public override string ToString()
        {
            return закупкаID + " | " + поставщикID + " | " + комплектующиеID + " | " + Количество + " | " + Дата_доставки;
        }
    }
    public class DB_zak : DataContext
    {
        public DB_zak(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Закупка> Закупка
        {
            get { return this.GetTable<Закупка>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(int поставщикID, int комплетующиеID, int Количество, DateTimeOffset Дата_доставки)
        {
            Закупка zak = new Закупка();
            zak.поставщикID = поставщикID;
            zak.комплектующиеID = комплетующиеID;
            zak.Количество = Количество;
            zak.Дата_доставки = Дата_доставки;
            this.Закупка.InsertOnSubmit(zak);
            this.SubmitChanges();
        }

        public void Edit(int закупкаID, int поставщикID, int комплетующиеID, int Количество, DateTimeOffset Дата_доставки)
        {
            Закупка zak = this.Закупка.Where(c => c.закупкаID == закупкаID).FirstOrDefault();
            zak.поставщикID = поставщикID;
            zak.комплектующиеID = комплетующиеID;
            zak.Количество = Количество;
            zak.Дата_доставки = Дата_доставки;
            this.SubmitChanges();
        }

        public void Delete(int закупкаID)
        {
            Закупка zak = this.Закупка.Where(c => c.закупкаID == закупкаID).FirstOrDefault();
            this.Закупка.DeleteOnSubmit(zak);
            this.SubmitChanges();
        }
        public List<Закупка> Vivod(int закупкаID)
        {
            return this.Закупка.Select(c => c).ToList();
        }
    }
}

