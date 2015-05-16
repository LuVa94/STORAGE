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
    public class Комплектующие
    {
        
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int комплектующиеID
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
        public int Количество
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

        private EntitySet<Поставщик> post = new EntitySet<Поставщик>();
        [Association(Storage = "post", OtherKey = "комплектующиеID")]
        public EntitySet<Поставщик> Поставщик
        {
            get { return post; }
            set { post.Assign(value); }
        }
       

        public override string ToString()
        {
            return комплектующиеID + " | " + Название + " | " + Количество + " | "  + Длина + " | " + Ширина + " | " + Глубина + " | " + Стоимость;
        }

    }
    public class DB_com : DataContext
    {
        public DB_com(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Комплектующие> Комплектующие
        {
            get { return this.GetTable<Комплектующие>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(string Название, int Количество,  int Длина, int Ширина, int Глубина, int Стоимость)
        {
            Комплектующие kom = new Комплектующие();
            kom.Название=Название;
            kom.Количество = Количество;
            kom.Длина = Длина;
            kom.Ширина = Ширина;
            kom.Глубина = Глубина;
            kom.Стоимость = Стоимость;
            this.Комплектующие.InsertOnSubmit(kom);
            this.SubmitChanges();
        }

        public void Edit(int комплектующиеID, string Название, int Количество,  int Длина, int Ширина, int Глубина, int Стоимость)
        {
            Комплектующие kom = this.Комплектующие.Where(c => c.комплектующиеID == комплектующиеID).FirstOrDefault();
            kom.Название = Название;
            kom.Количество = Количество;
            kom.Длина = Длина;
            kom.Ширина = Ширина;
            kom.Глубина = Глубина;
            kom.Стоимость = Стоимость;
            this.SubmitChanges();
        }

        public void Delete(int комплектующиеID)
        {
            Комплектующие kom = this.Комплектующие.Where(c => c.комплектующиеID == комплектующиеID).FirstOrDefault();
            this.Комплектующие.DeleteOnSubmit(kom);
            this.SubmitChanges();
        }
        public List<Комплектующие> Vivod(int комплектующиеID)
        {
            return this.Комплектующие.Select(c => c).ToList();
        }
    }
}
