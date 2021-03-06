﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Win
{
    [Table]
    public class Материал
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int материалID
        {
            get;
            set;
        }
        [Column]
        public string  Название
        {
            get;
            set;
        }
        [Column]
        public int Стоимость_за_1_кв_м
        {
            get;
            set;
        }

        private EntitySet<Заказ> bb = new EntitySet<Заказ>();
        [Association(Storage = "bb", OtherKey = "заказID")]
        public EntitySet<Заказ> Заказ
        {
            get { return bb; }
            set { bb.Assign(value); }
        }

        public override string ToString()
        {
            return материалID + " | " + Название + " | " + Стоимость_за_1_кв_м;
        }
    }
    public class DB_sost : DataContext
    {
        public DB_sost(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Материал> Материал
        {
            get { return this.GetTable<Материал>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(string Название, int Стоимость_за_1_кв_м)
        {
            Материал sost = new Материал();
            sost.Название = Название;
            sost.Стоимость_за_1_кв_м = Стоимость_за_1_кв_м;
            this.Материал.InsertOnSubmit(sost);
            this.SubmitChanges();
        }

        public void Edit(int материалID, string Название, int Стоимость_за_1_кв_м)
        {
            Материал sost = this.Материал.Where(c => c.материалID == материалID).FirstOrDefault();
            sost.Название = Название;
            sost.Стоимость_за_1_кв_м = Стоимость_за_1_кв_м;
            this.SubmitChanges();
        }

        public void Delete(int материалID)
        {
            Материал sost = this.Материал.Where(c => c.материалID == материалID).FirstOrDefault();
            this.Материал.DeleteOnSubmit(sost);
            this.SubmitChanges();
        }
        public List<Материал> Vivod(int материалID)
        {
            return this.Материал.Select(c => c).ToList();
        }
    }
}
