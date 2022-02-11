using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Factory_1._1
{
    public partial class Form1 : Form
    {
        StreamWriter fw;    // поток записи в файл
        StreamReader fr;    // поток чтения из файла 
        
        public Form1()
        {
            InitializeComponent();
        }
        Factory FactoryOne;

        private void Form1_Load(object sender, EventArgs e)
        {
            fr = new StreamReader("Factory.txt");
            string s1 = fr.ReadLine();
            double s2 = Convert.ToDouble(fr.ReadLine());
            string s3 = fr.ReadLine();
            string s4 = fr.ReadLine();
            FactoryOne = new Factory(s1, s2, s3);
            FactoryOne.Price = decimal.Parse(s4);
            fr.Close();
            
        }

       

        private void buttonInfo_Click_1(object sender, EventArgs e)
        {
            richTextBoxMonitor.Text = FactoryOne.Info();

        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            string s = textBoxLoad.Text;
            double x = double.Parse(s);
            double realLoad = FactoryOne.LoadFactory(x);
            int ind = FactoryOne.MagazineLoad.Count;
            MessageBox.Show((FactoryOne.MagazineLoad[ind - 1]).Info());
            richTextBoxMonitor.Text = FactoryOne.Info(); 
            fw = new StreamWriter("MagazineLoad.txt");
            for (int i = 0; i < FactoryOne.MagazineLoad.Count; i++)
            {
                fw.WriteLine("Индекс завода: " + FactoryOne.MagazineLoad[i].IndexFactory);
                fw.WriteLine("Марка марли: " + FactoryOne.MagazineLoad[i].Grade);
                fw.WriteLine("Дата загрузки: " + FactoryOne.MagazineLoad[i].DateLoad);
                fw.WriteLine("Фактически загружено кг: " + FactoryOne.MagazineLoad[i].AmountLoad);
            }
            fw.Close();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            string s = textBoxSale.Text;
            double x = double.Parse(s);
            double realSale = FactoryOne.SaleFactory(x);
            int ind = FactoryOne.MagazineSale.Count;
            MessageBox.Show(FactoryOne.MagazineSale[ind - 1].Info());
            richTextBoxMonitor.Text = FactoryOne.Info();
            fw = new StreamWriter("MagazineSale.txt");
            for (int i = 0; i < FactoryOne.MagazineSale.Count; i++)
            {
                fw.WriteLine("Индекс завода: " + FactoryOne.MagazineSale[i].IndexFactory);
                fw.WriteLine("Марка марли: " + FactoryOne.MagazineSale[i].Grade);
                fw.WriteLine("Цена за 1 шт: " + FactoryOne.MagazineSale[i].Price);
                fw.WriteLine("Дата продажи: " + FactoryOne.MagazineSale[i].DateSale);
                fw.WriteLine("Фактически продано шт: " + FactoryOne.MagazineSale[i].AmountSale);
                fw.WriteLine("Получено с клиента рублей: " + FactoryOne.MagazineSale[i].Proceeds);
            }
            fw.Close();
            
            
        }

        private void buttonMagazine_Click(object sender, EventArgs e)
        {
            richTextBoxMonitor.Clear();
            for (int i = 0; i < FactoryOne.MagazineLoad.Count; i++)
            {
                richTextBoxMonitor.Text += (FactoryOne.MagazineLoad[i]).Info();
            }
            for (int i = 0; i < FactoryOne.MagazineMake.Count; i++)
            {
                richTextBoxMonitor.Text += (FactoryOne.MagazineMake[i]).Info();

            }
            for (int i = 0; i < FactoryOne.MagazineSale.Count; i++)
            {
                richTextBoxMonitor.Text += (FactoryOne.MagazineSale[i]).Info();
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            richTextBoxMonitor.Clear();
            double y = Convert.ToDouble(textBoxMake.Text);
            if (FactoryOne.Amount >=y*0.02 )
            {
                double x = Convert.ToDouble(textBoxMake.Text);

                double s = FactoryOne.MakeMask(x);
                int ind = FactoryOne.MagazineMake.Count;
                MessageBox.Show((FactoryOne.MagazineMake[ind - 1]).Info());
                richTextBoxMonitor.Text = FactoryOne.Info();
                fw = new StreamWriter("MagazineMake.txt");
                for (int i = 0; i < FactoryOne.MagazineMake.Count; i++)
                {
                    fw.WriteLine("Индекс завода: " + FactoryOne.MagazineMake[i].IndexFactory);
                    fw.WriteLine("Марка марли: " + FactoryOne.MagazineMake[i].Grade);
                    fw.WriteLine("Дата изготовления: " + FactoryOne.MagazineMake[i].DateMake);
                    fw.WriteLine("Фактически сделанно шт: " + FactoryOne.MagazineMake[i].AmountMask);
                }
                fw.Close();
            }
            else
            {
                MessageBox.Show("Недостаточно марли");
            }
        }

        private void textBoxLoad_TextChanged(object sender, EventArgs e)
        {

           
        }
    }
}
