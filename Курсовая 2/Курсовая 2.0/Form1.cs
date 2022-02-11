using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.bdDataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Credit". При необходимости она может быть перемещена или удалена.
            this.creditTableAdapter.Fill(this.bdDataSet.Credit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.bdDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.bdDataSet.Group);
            
           
            

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupTableAdapter.Update(this.bdDataSet);
            this.studentTableAdapter.Update(this.bdDataSet);
            this.creditTableAdapter.Update(this.bdDataSet);
            this.examTableAdapter.Update(this.bdDataSet);


        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//Выход из программы
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }



       

        private void ЭкзаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ЗачётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView3.Size.Width + 10, dataGridView3.Size.Height + 10);
            dataGridView3.DrawToBitmap(bmp, dataGridView3.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView4.Size.Width + 10, dataGridView4.Size.Height + 10);
            dataGridView4.DrawToBitmap(bmp, dataGridView4.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupTableAdapter.Update(this.bdDataSet);
            this.studentTableAdapter.Update(this.bdDataSet);
            this.creditTableAdapter.Update(this.bdDataSet);
            this.examTableAdapter.Update(this.bdDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupTableAdapter.Update(this.bdDataSet);
            this.studentTableAdapter.Update(this.bdDataSet);
            this.creditTableAdapter.Update(this.bdDataSet);
            this.examTableAdapter.Update(this.bdDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.groupTableAdapter.Update(this.bdDataSet);
            this.studentTableAdapter.Update(this.bdDataSet);
            this.creditTableAdapter.Update(this.bdDataSet);
            this.examTableAdapter.Update(this.bdDataSet);
        }
        

        

        
    }
}
