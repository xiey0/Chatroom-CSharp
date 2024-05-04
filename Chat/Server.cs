using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
namespace Chat;

class Program
{
    static async void Accept(){
        
    }
    static void Main(string[] args)
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        s.Bind(new IPEndPoint(ip, 2300));
        s.Listen(100);
        while (true)
        {

            Socket temp = s.Accept();
            string receiveStr = "";
            byte[] receiveBytes = new byte[1024];
            int bytes;
            bytes = temp.Receive(receiveBytes, receiveBytes.Length, 0);
            receiveStr += Encoding.ASCII.GetString(receiveBytes, 0, bytes);
            Console.WriteLine(receiveStr);
            temp.Close();
        }



    }
}
