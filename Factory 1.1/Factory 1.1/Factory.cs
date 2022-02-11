using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Factory_1._1
{
    class Factory
    {
        public string IndexFactory { get; set; }  // индекс завода
        public double Volume { get; set; }           // объем склада
        public double Amount { get; set; }       // количество продукта
        public string Grade { get; set; }        // марка продукта
        public decimal Price { get; set; }       // цена
        public List<Sale> MagazineSale;          // журнал продаж
        public List<Load> MagazineLoad;         // журнал загрузок
        public List<Make> MagazineMake;       //журнал производства
        public double AmountMask { get; set; } // количество масок

        public Factory(string IndexFactory, double Volume, string Grade)
        {
            this.IndexFactory = IndexFactory;
            this.Volume = Volume;
            this.Grade = Grade;
            MagazineLoad = new List<Load>();
            MagazineSale = new List<Sale>();
            MagazineMake = new List<Make>();
        }
        public double LoadFactory(double x)    // х - попытка загрузки (кг)
        {        
            double portionFactory = Math.Min(x, Volume - Amount); // фактически загружено
            Amount += portionFactory;  // Корректировка содержимого склада 
            // создаем объект "загрузка"
            Load lod = new Load(IndexFactory, Grade, portionFactory);
            // объект "загрузка" - в журнал
            MagazineLoad.Add(lod);
            return portionFactory;
        }
        //Метод: продать "х" шт. х - это заказ
        public double SaleFactory(double x)
        {
            double portionFactory = Math.Min(AmountMask, x); // фактически будет продано
            AmountMask -= portionFactory;  // Корректировка содержимого склада
            // создаем объект "продажа"
            Sale sal = new Sale(IndexFactory, Grade, Price, portionFactory);
            //sal.DateSale = DateTime.Now;
            // объект "продажа" - в журнал
            MagazineSale.Add(sal);
            return portionFactory;
        }
        public double MakeMask(double x)
        {
            
            double y = x * 0.02;
            double portionFactory = Math.Min(Amount, y);
            Amount -= portionFactory;
            
            Make make = new Make(IndexFactory, Grade, x);
            MagazineMake.Add(make);
            x = y / 0.02;
            AmountMask = AmountMask + x;
            return portionFactory;
        }
        public string Info()
        {
            string s;
            s = string.Format("Завод {0}\n", IndexFactory);
            s = s + string.Format("Объем склада= {0} кг\n", Volume);
            s = s + string.Format("Марка марли: {0}\n", Grade);
            s = s + string.Format("Цена 1шт = {0} руб\n", Price);
            s = s + string.Format("Количество марли на складе = {0} кг\n", Amount);
            s = s + string.Format("Количество масок на складе = {0} n", AmountMask);
            return s;
        }
    }
     
     
}
