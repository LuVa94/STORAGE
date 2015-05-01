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
    public class Мебель
    {
        [Column(IsPrimaryKey = true, IsDbGenerated=true)]
        public int мебельID
           {
              get;
              set;
           }
        [Column]
        public string Название
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

        private EntitySet<Составляющие> sost = new EntitySet<Составляющие>();
        [Association(Storage = "sost", OtherKey = "мебельID")]
        public EntitySet<Составляющие> Составляющие
        {
            get { return sost; }
            set { sost.Assign(value); }
        }
        private EntitySet<Заказ> zz = new EntitySet<Заказ>();
        [Association(Storage = "zz", OtherKey = "заказID")]
        public EntitySet<Заказ> Заказ
        {
            get { return zz; }
            set { zz.Assign(value); }
        }
        private EntitySet<Список_заказов> sz = new EntitySet<Список_заказов>();
        [Association(Storage = "sz", OtherKey = "ID")]
        public EntitySet<Список_заказов> Список_заказов
        {
            get { return sz; }
            set { sz.Assign(value); }
        }

        public override string ToString()
        {
            return мебельID + " | " + Название + " | " + Длина + " | " + Ширина + " | " + Глубина;
        }
        
    }
    public class DB_meb : DataContext
    {
        public DB_meb(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Мебель> Мебель
        {
            get { return this.GetTable<Мебель>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD ( string Название, int Длина, int Ширина, int Глубина)
        {
            Мебель meb = new Мебель();
            meb.Название = Название;
            meb.Длина = Длина;
            meb.Ширина = Ширина;
            meb.Глубина = Глубина;
            this.Мебель.InsertOnSubmit(meb);
            this.SubmitChanges();
        }

        public void Edit(int мебельID, string Название, int Длина, int Ширина, int Глубина)
        {
            Мебель meb = this.Мебель.Where(c => c.мебельID == мебельID).FirstOrDefault();
            meb.Название = Название;
            meb.Длина = Длина;
            meb.Ширина = Ширина;
            meb.Глубина = Глубина;
            this.SubmitChanges();
        }

        public void Delete(int мебельID)
        {
            Мебель meb = this.Мебель.Where(c => c.мебельID == мебельID).FirstOrDefault();
            this.Мебель.DeleteOnSubmit(meb);
            this.SubmitChanges();
        }
        public List<Мебель> Vivod(int мебельID)
        {
            return this.Мебель.Select(c => c).ToList();
        }
    }

}
