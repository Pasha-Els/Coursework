using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Курсач_ПСП
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private const int port = 8888;
        private const string server = "127.0.0.1";
        TcpClient client = new TcpClient();
        StringBuilder response = new StringBuilder();
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пСПDataSet.Site". При необходимости она может быть перемещена или удалена.
            this.siteTableAdapter.Fill(this.пСПDataSet.Site);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пСПDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.пСПDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пСПDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.пСПDataSet.Clients);
           
            
            

            
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.siteTableAdapter.Update(this.пСПDataSet.Site);
            
            this.zakazTableAdapter.Update(this.пСПDataSet.Zakaz);
            
            this.clientsTableAdapter.Update(this.пСПDataSet.Clients);
            
           /* client = new TcpClient();
            client.Connect(server, port);*/
            /*byte[] data = new byte[client.ReceiveBufferSize];
            NetworkStream stream = client.GetStream();

            byte[] bzapros = Encoding.UTF8.GetBytes("3");
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);

            int bytes = stream.Read(data, 0, client.ReceiveBufferSize);
            response.Append(Encoding.UTF8.GetString(data, 0, bytes));
            string resp = response.ToString();

            string[] titlesAndValues = resp.Split(',');
            string[] titles = titlesAndValues[0].Split('+');
            string[] values = titlesAndValues[1].Split(';');

            for (int i = 0; i < titles.Length; i++)
            {
                dataGridView1.Columns.Add(titles[i], titles[i]);
            }

            for (int i = 0; i < values.Length; i += 5)
            {
                dataGridView1.Rows.Add(values[i], values[i + 1], values[i + 2], values[i + 3], values[i + 4]);
            }*/

           /* byte[] data = new byte[client.ReceiveBufferSize];
            NetworkStream stream = client.GetStream();
            byte[] bzapros = Encoding.UTF8.GetBytes("3");
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            StringBuilder response = new StringBuilder();
            int bytes = stream.Read(data, 0, client.ReceiveBufferSize);
            response.Append(Encoding.UTF8.GetString(data, 0, bytes));
            int count = Convert.ToInt32(Encoding.UTF8.GetString(data, 0, bytes));
            String[] A = new string[4];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 4;j++ )
                {
                    bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                    A[j] = Encoding.UTF8.GetString(data, 0, bytes);
                     
                }
               
            }
            dataGridView1.Rows.Add(A[0],A[1],A[2],A[3]);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            client = new TcpClient();
            client.Connect(server, port);

            byte[] data = new byte[client.ReceiveBufferSize];
            NetworkStream stream = client.GetStream();

            byte[] bzapros = Encoding.UTF8.GetBytes("2");
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            bzapros = Encoding.UTF8.GetBytes(comboBox1.Text);
            stream.Write(bzapros, 0, bzapros.Length);
            Thread.Sleep(100);
            
            /*string idsite = "SELECT idsite FROM Site WHERE Addresssite ='"+comboBox1.Text+"'";
            SqlDataReader reader;
            SqlCommand command = new SqlCommand(idsite, connection);
            int numid = Convert.ToInt32(command.ExecuteScalar().ToString());

                string sqlExpression = "DELETE FROM Zakaz WHERE idorder ='"+numid+"'";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                reader.Close();

                sqlExpression = "DELETE FROM Site WHERE idsite ='"+numid+"'";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                reader.Close();

                sqlExpression = "DELETE FROM Clients WHERE idclient ='"+numid+"'";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                reader.Close();
            connection.Close();*/
            
            File.Delete(@"C:\Users\zuza5\Desktop\Курсач ПСП\Курсач ПСП\bin\Debug\"+comboBox1.Text+".txt");
        }

       

        

       
        
    }
}
