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
    public class Клиент
     {
     [Column(IsPrimaryKey = true, IsDbGenerated=true)]
        public int клиентID
           {
              get;
              set;
           }
        [Column]
        public string ФИО
        {
            get;
            set;
        }
        [Column]
        public string Контактный_телефон
        {
            get;
            set;
        }
        [Column]
        public string Электронная_почта
        {
            get;
            set;
        }

        public override string ToString()
        {
            return клиентID + " | " + ФИО + " | " + Контактный_телефон + " | " + Электронная_почта;
        }
        
    }
    public class DB_kl : DataContext
    {
        public DB_kl(string cs)
            : base(cs)
        {
        }
        public System.Data.Linq.Table<Клиент> Клиент
        {
            get { return this.GetTable<Клиент>(); }
        }
        public void Check()
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }
        public void ADD(string ФИО, string Контактный_телефон, string Электронная_почта)
        {
            Клиент kl = new Клиент();
            kl.ФИО = ФИО;
            kl.Контактный_телефон = Контактный_телефон;
            kl.Электронная_почта = Электронная_почта;
            this.Клиент.InsertOnSubmit(kl);
            this.SubmitChanges();
        }

        public void Edit(int клиентID, string ФИО, string Контактный_телефон, string Электронная_почта)
        {
            Клиент kl = this.Клиент.Where(c => c.клиентID == клиентID).FirstOrDefault();
            kl.ФИО = ФИО;
            kl.Контактный_телефон = Контактный_телефон;
            kl.Электронная_почта = Электронная_почта;
            this.SubmitChanges();
        }

        public void Delete(int клиентID)
        {
            Клиент kl = this.Клиент.Where(c => c.клиентID == клиентID).FirstOrDefault();
            this.Клиент.DeleteOnSubmit(kl);
            this.SubmitChanges();
        }
        public List<Клиент> Vivod(int клиентID)
        {
            return this.Клиент.Select(c => c).ToList();
        }
    }
}
