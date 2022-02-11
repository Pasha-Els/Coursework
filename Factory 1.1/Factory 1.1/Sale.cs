using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1._1
{
    class Sale  // Класс "продажа"
    {
        public string IndexFactory { get; set; }
        public string Grade { get; set; }
        public decimal Price { get; set; }  // Цена за 1 шт
        public DateTime DateSale { get; set; }  // Дата продажи
        public double AmountSale { get; set; }  // Количество проданного 
        public decimal Proceeds { get; set; }   // Выручка за продажу
        // Конструктор
        public Sale(string IndexFactory, string Grade, decimal Price,
            double AmountSale)
        {
            this.IndexFactory = IndexFactory;
            this.Grade = Grade;
            this.Price = Price;
            this.AmountSale = AmountSale;
            DateSale = DateTime.Now;
            Proceeds = (decimal)AmountSale * Price;
        }
        public string Info()
        {
            string s = "Сеанс продажи масок\n";
            s = s + string.Format("Индекс завода: {0}\n", IndexFactory);
            s = s + string.Format("Марка марли: {0}\n", Grade);
            s = s + string.Format("Цена за 1 шт: {0}\n", Price);
            s = s + string.Format("Дата продажи: {0}\n", DateSale);
            s = s + string.Format("Фактически продано шт: {0}\n", AmountSale);
            s = s + string.Format("Получено с клиента рублей: {0}\n", Proceeds);
            s = s + "\n";
            return s;
        }

    }
}
