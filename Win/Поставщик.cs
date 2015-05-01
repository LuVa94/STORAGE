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
    public class Поставщик
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int поставщикID
        {
            get;
            set;
        }
        [Column]
        public string Название_организации
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

        private EntityRef<Комплектующие> com;
        [Association(Storage = "com", ThisKey = "поставщикID", OtherKey = "комплектующиеID",
        IsForeignKey = true)]
        public Комплектующие Комплектующие
        {
            get { return com.Entity; }
            set
            {
                com.Entity = value;
                if (value != null) комплектующиеID = value.комплектующиеID;
            }
        }
        private EntitySet<Закупка> zzz = new EntitySet<Закупка>();
        [Association(Storage = "zzz", OtherKey = "закупкаID")]
        public EntitySet<Закупка> Закупка
        {
            get { return zzz; }
            set { zzz.Assign(value); }
        }

        public override string ToString()
        {
            return поставщикID + " | " + Название_организации + " | " + комплектующиеID;
        }

    }
    public class DB_post : DataContext
    {
        public DB_post(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Поставщик> Поставщик
        {
            get { return this.GetTable<Поставщик>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(string Название_организации, int комплетующиеID)
        {
            Поставщик post = new Поставщик();
            post.Название_организации = Название_организации;
            post.комплектующиеID = комплетующиеID;
            this.Поставщик.InsertOnSubmit(post);
            this.SubmitChanges();
        }

        public void Edit(int поставщикID, string Название_организации, int комплетующиеID)
        {
            Поставщик post = this.Поставщик.Where(c => c.поставщикID == поставщикID).FirstOrDefault();
            post.Название_организации = Название_организации;
            post.комплектующиеID = комплетующиеID;
            this.SubmitChanges();
        }

        public void Delete(int поставщикID)
        {
            Поставщик post = this.Поставщик.Where(c => c.поставщикID == поставщикID).FirstOrDefault();
            this.Поставщик.DeleteOnSubmit(post);
            this.SubmitChanges();
        }
        public List<Поставщик> Vivod(int поставщикID)
        {
            return this.Поставщик.Select(c => c).ToList();
        }
    }
}
