using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Threading;
using System.Data;



namespace Курсач_Сервер
{
    class Program
    {
        

        static void Main(string[] args)
        {

            TcpListener server = null;
            SqlCommand command;
            SqlDataReader reader;
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            server.Start();
            string connectionString = @"Data Source=DESKTOP-LSLN6FR\PAVEL;Initial Catalog=ПСП;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
       
            
            while (true)
            {
                
            

                
                Console.WriteLine("Ожидание подключений... ");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Подключен клиент. Выполнение запроса");
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[client.ReceiveBufferSize];
                StringBuilder response = new StringBuilder();
                int bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                int cas = Convert.ToInt32(Encoding.UTF8.GetString(data, 0, bytes));
                switch(cas)
                {
                    case 1:
                        connection.Open();
                        command = new SqlCommand("SELECT COUNT(idclient) FROM Clients", connection);
            int countclient = Convert.ToInt32(command.ExecuteScalar().ToString());
            command = new SqlCommand("SELECT COUNT(idsite) FROM Site", connection);
            int countsite = Convert.ToInt32(command.ExecuteScalar().ToString());
            command = new SqlCommand("SELECT COUNT(idorder) FROM Zakaz", connection);
            int countorder = Convert.ToInt32(command.ExecuteScalar().ToString());

                countclient++;
                countorder++;
                countsite++;

                bytes = stream.Read(data, 0, client.ReceiveBufferSize);                
                string fio = Encoding.UTF8.GetString(data, 0, bytes);

                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string address = Encoding.UTF8.GetString(data, 0, bytes);

                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                int phonenumber = Convert.ToInt32(Encoding.UTF8.GetString(data, 0, bytes));

                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string email = Encoding.UTF8.GetString(data, 0, bytes);

                string sqlExpression = "INSERT INTO Clients (idclient, FIO, Address, Phonenumber, Email) VALUES ('" + countclient + "','" + fio + "','" + address + "','" + phonenumber + "','" + email + "')";
                command = new SqlCommand(sqlExpression, connection);

                reader = command.ExecuteReader();
                reader.Close();

                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string addresssite = Encoding.UTF8.GetString(data, 0, bytes);
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string siteview = Encoding.UTF8.GetString(data, 0, bytes);
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string promotion = Encoding.UTF8.GetString(data, 0, bytes);
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string hosting = Encoding.UTF8.GetString(data, 0, bytes);
                sqlExpression = "INSERT INTO Site (idsite, Addresssite, Siteview, Promotion, Hosting) VALUES ('" + countsite + "','" + addresssite + "','" + siteview + "','" + promotion + "','" + hosting + "')";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                reader.Close();
                            
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                DateTime date = Convert.ToDateTime(Encoding.UTF8.GetString(data, 0, bytes));
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string employee = Encoding.UTF8.GetString(data, 0, bytes);
                bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                int price = Convert.ToInt32(Encoding.UTF8.GetString(data, 0, bytes));

                sqlExpression = "INSERT INTO Zakaz (idorder, Date, Employee, Price, idsite, idclient) VALUES ('" + countorder + "','" + date + "','" + employee + "','" + price + "','" + countsite + "','" + countclient + "')";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
                break;
                    case 2:
                connection.Open();
                        bytes = stream.Read(data, 0, client.ReceiveBufferSize);
                string sitename = Encoding.UTF8.GetString(data, 0, bytes);
                string idsite = "SELECT idsite FROM Site WHERE Addresssite ='" + sitename + "'";

                        command = new SqlCommand(idsite, connection);
            int numid = Convert.ToInt32(command.ExecuteScalar().ToString());

                       
                        sqlExpression = "DELETE FROM Zakaz WHERE idorder ='"+numid+"'";
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
                connection.Close();

            
                break;

                    case 3:
                connection.Open();
                

                       /* command = new SqlCommand("SELECT * FROM Clients", connection);

                            reader = command.ExecuteReader();
                            
                            string resp = "";

                            if (reader.HasRows) // если есть данные
                            {
                                resp += reader.GetName(0) + "+" + reader.GetName(1) + "+" + reader.GetName(2) + "+" + reader.GetName(3) + "+" + reader.GetName(4) + ",";
                                while (reader.Read()) // построчно считываем данные
                                {

                                    resp += reader.GetValue(0).ToString() + ";" + reader.GetValue(1).ToString() + ";" + reader.GetValue(2).ToString() + ";" + reader.GetValue(2).ToString() + ";" + reader.GetValue(4).ToString() + ";";
                                    
                                }
                            }

                            data = Encoding.Unicode.GetBytes(resp);
                             stream.Write(data, 0, data.Length);
                                Thread.Sleep(10);*/
                        
               /* command = new SqlCommand("SELECT COUNT(*) FROM Clients",connection);
                int count = Convert.ToInt32(command.ExecuteScalar().ToString());
                reader = command.ExecuteReader();
                reader.Close();
                data = Encoding.UTF8.GetBytes(count.ToString());
                stream.Write(data, 0, data.Length);
                command = new SqlCommand("SELECT FIO, Address, Phonenumber, Email FROM Clients",connection);
                reader = command.ExecuteReader();
                for (int i = 0; i < count; i++)
                    {
                        reader.Read();
                        for (int j = 1; j < 4; j++)
                            {
                                data = Encoding.UTF8.GetBytes(reader[j].ToString());
                                stream.Write(data, 0, data.Length);
                                Thread.Sleep(10);
                            }
                    }
                reader.Close();
                connection.Close();*/

                break;
                    case 4:

                break;


                }

                
            }
            
            








        }
    }
}
