using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
namespace Chat;

class Program
{

    static void Main(string[] args)
    {
        



    }
    static async Task MakeSocket()
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(new IPEndPoint(IPAddress.Any, 25667));
        socket.Listen(10);
        var temp = socket.AcceptAsync();

    }
}
