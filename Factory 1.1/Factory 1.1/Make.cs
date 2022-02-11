using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1._1
{
    class Make
    {
        public string IndexFactory { get; set; } // Инрдекс завода
        public DateTime DateMake { get; set; } // Дата создания маски
        public string Grade { get; set; } // Марка продукта
        public double AmountMask { get; set; } // Количество масок

        // Конструктор 
        public Make(string IndexFactory, string Grade, double AmountMask)
        {
            this.IndexFactory = IndexFactory;
            this.Grade = Grade;
            DateMake = DateTime.Now;
            this.AmountMask = AmountMask;
        }
        public string Info()
        {
            string s = "Сеанс производства масок\n";
            s = s + string.Format("Индекс завода: {0}\n", IndexFactory);
            s = s + string.Format("Марка марли: {0}\n", Grade);
            s = s + string.Format("Дата изготовления: {0}\n", DateMake);
            s = s + string.Format("Фактически сделанно шт: {0}\n", AmountMask);
            s = s + "\n";
            return s;
        }




    }
}
