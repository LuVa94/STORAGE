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
    public class Список_заказов
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public int заказID
        {
            get;
            set;
        }
        public int мебельID
        {
            get;
            set;
        }
        public int Количество
        {
            get;
            set;
        }
        private EntityRef<Мебель> m;
        [Association(Storage = "m", ThisKey = "ID", OtherKey = "мебельID",
        IsForeignKey = true)]
        public Мебель Мебель
        {
            get { return m.Entity; }
            set
            {
                m.Entity = value;
                if (value != null) мебельID = value.мебельID;
            }
        }
        private EntityRef<Заказ> q;
        [Association(Storage = "q", ThisKey = "ID", OtherKey = "заказID",
        IsForeignKey = true)]
        public Заказ Заказ
        {
            get { return q.Entity; }
            set
            {
                q.Entity = value;
                if (value != null) заказID = value.заказID;
            }
        }
        public override string ToString()
        {
            return ID + " | " + заказID + " | " + мебельID + " | " + Количество;
        }
    }
    public class DB_szak : DataContext
    {
        public DB_szak(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Список_заказов> Список_заказов
        {
            get { return this.GetTable<Список_заказов>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(int заказID, int мебельID, int Количество)
        {
            Список_заказов szak = new Список_заказов();
            szak.заказID = заказID;
            szak.мебельID = мебельID;
            szak.Количество = Количество;
            this.Список_заказов.InsertOnSubmit(szak);
            this.SubmitChanges();
        }

        public void Edit(int ID, int заказID, int мебельID, int Количество)
        {
            Список_заказов szak = this.Список_заказов.Where(c => c.ID == ID).FirstOrDefault();
            szak.заказID = заказID;
            szak.мебельID = мебельID;
            szak.Количество = Количество;
            this.SubmitChanges();
        }

        public void Delete(int ID)
        {
            Список_заказов szak = this.Список_заказов.Where(c => c.ID == ID).FirstOrDefault();
            this.Список_заказов.DeleteOnSubmit(szak);
            this.SubmitChanges();
        }
        public List<Список_заказов> Vivod(int ID)
        {
            return this.Список_заказов.Select(c => c).ToList();
        }
    }
}
