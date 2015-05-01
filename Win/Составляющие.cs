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
    public class Составляющие
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int составляющиеID
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

        private EntityRef<Мебель> mmm;
        [Association(Storage = "mmm", ThisKey = "составляющиеID", OtherKey = "мебельID",
        IsForeignKey = true)]
        public Мебель Мебель
        {
            get { return mmm.Entity; }
            set
            {
                mmm.Entity = value;
                if (value != null) мебельID = value.мебельID;
            }
        }
        private EntityRef<Комплектующие> kkk;
        [Association(Storage = "kkk", ThisKey = "составляющиеID", OtherKey = "комплектующиеID",
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
            return составляющиеID + " | " + мебельID + " | " + комплектующиеID + " | " + Количество;
        }
    }
    public class DB_sost : DataContext
    {
        public DB_sost(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Составляющие> Составляющие
        {
            get { return this.GetTable<Составляющие>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(int мебельID, int комплетующиеID, int Количество)
        {
            Составляющие sost = new Составляющие();
            sost.мебельID = мебельID;
            sost.комплектующиеID = комплетующиеID;
            sost.Количество = Количество;
            this.Составляющие.InsertOnSubmit(sost);
            this.SubmitChanges();
        }

        public void Edit(int составляющиеID, int мебельID, int комплетующиеID, int Количество)
        {
            Составляющие sost = this.Составляющие.Where(c => c.составляющиеID == составляющиеID).FirstOrDefault();
            sost.мебельID = мебельID;
            sost.комплектующиеID = комплетующиеID;
            sost.Количество = Количество;
            this.SubmitChanges();
        }

        public void Delete(int составляющиеID)
        {
            Составляющие sost = this.Составляющие.Where(c => c.составляющиеID == составляющиеID).FirstOrDefault();
            this.Составляющие.DeleteOnSubmit(sost);
            this.SubmitChanges();
        }
        public List<Составляющие> Vivod(int составляющиеID)
        {
            return this.Составляющие.Select(c => c).ToList();
        }
    }
}
