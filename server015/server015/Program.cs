using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server015
{
    class Program
    {
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();

        static void Main(string[] args)
        {

            Console.WriteLine("Server hangi portta Çalışsın: ");
            string portNo = Console.ReadLine();
            Console.WriteLine("Server "+portNo+"'unda çalışmaya başladı..");
            int count = 1;
            //Yukarısı; Server port bilgisini alır.
            TcpListener ServerSocket = new TcpListener(IPAddress.Any, Int32.Parse(portNo));
            ServerSocket.Start();
            //Yukarısı; Tcp bağlantısı ile alınan port numarasına göre server'ı başlatır.
            while (true)
            {
                TcpClient client = ServerSocket.AcceptTcpClient();
                lock (_lock) list_clients.Add(count, client);
                Console.WriteLine("Client "+count+ " connected!!");               
                // Server dinlemeye geçer. Client bağlantısı olursa konsola yazar.
                Thread t = new Thread(handle_clients);
                t.Start(count);
                count++;
                // t threadına gider, burada client'lardan gelen mesajları dinler.
            }
        }
        public static void handle_clients(object o)
        {
            // servere gelen mesajları alır. Bu mesajları String tipine dönüştürür
            //Ve broadCast methoduna string olarak gönderir.            
            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream(); // stream üzerinden client'taki veriyi al.
                byte[] buffer = new byte[30774];
                int byte_count = stream.Read(buffer, 0, buffer.Length);   // byte veriyi oku, uzunluğunu al.             
                if (byte_count == 0)
                { // eğer byte veri boyutu sıfır ile veri gelmemiş demektir. Döngüden çık.
                    break;
                }                
                string data = Convert.ToBase64String(buffer);               
                broadcast(data);               
                if (buffer[0] < 200)                
                    Console.WriteLine("Mesaj Gonderildi!");
                else                
                    Console.WriteLine("Resim Gonderildi!");
            }
            lock (_lock) list_clients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();             
        }
        public static void broadcast(string data)
        {
            // gelen string mesajları alır. Server'a bağlı tüm client'lara gönderir.            
            byte[] buffer = Convert.FromBase64String(data);
            lock (_lock)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }       
    }
}
