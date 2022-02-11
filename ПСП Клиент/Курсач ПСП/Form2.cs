using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Drawing.Printing;


namespace Курсач_ПСП
{
    public partial class Form2 : Form
    {
        
        

        public Form2()
        {
            InitializeComponent();
        }


        private const int port = 8888;
        private const string server = "127.0.0.1";
        TcpClient client = new TcpClient();
        StringBuilder response = new StringBuilder();

     private void button1_Click(object sender, EventArgs e)
        {

            client = new TcpClient();
            client.Connect(server, port);

            byte[] data = new byte[client.ReceiveBufferSize];
            NetworkStream stream = client.GetStream();
            byte[] bzapros = Encoding.UTF8.GetBytes("1");
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(textBox1.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(105);
            bzapros = Encoding.UTF8.GetBytes(textBox2.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(textBox3.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(textBox4.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);

            bzapros = Encoding.UTF8.GetBytes(textBox5.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(comboBox1.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(comboBox3.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(comboBox2.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);

            DateTime dt = dateTimePicker1.Value;
            bzapros = Encoding.UTF8.GetBytes(dt.ToShortDateString());
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(comboBox4.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(textBox6.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);


         
         
         
           
            


        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
