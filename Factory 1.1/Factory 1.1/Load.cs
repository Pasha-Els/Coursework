using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1._1
{
    class Load
    {
        public DateTime DateLoad { get; set; }
        public string IndexFactory { get; set; }
        public string Grade { get; set; }
        public double AmountLoad { get; set; }
        public Load(string IndexFactory, string Grade, double AmountLoad)
        {
            this.IndexFactory = IndexFactory;
            this.Grade = Grade;
            this.AmountLoad = AmountLoad;
            DateLoad = DateTime.Now;
        }
       
        public string Info()
        {
            string s = "Сеанс загрузки марли\n";
            s = s + string.Format("Индекс завода: {0}\n", IndexFactory);
            s = s + string.Format("Марка марли: {0}\n", Grade);
            s = s + string.Format("Дата загрузки: {0}\n", DateLoad);
            s = s + string.Format("Фактически загружено кг: {0}\n", AmountLoad);
            s = s + "\n";
            return s;
        }








    }
}
