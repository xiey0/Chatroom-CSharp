﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Chat;



class Program
{

    static void Main(string[] args)
    {
        
        Console.WriteLine("Please write down your name.\n请写下你的名字。");
        start:
        string name = Console.ReadLine();
        if(name!=""){
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2300);

                s.Connect(iPEndPoint);

                string str = $"====== Welcome {name}! ======";
                byte[] a = Encoding.UTF8.GetBytes(str);
                s.Send(a, 0);
                s.Close();
            while (true)
            {
                Socket s2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iPEndPoint2 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2300);

                s2.Connect(iPEndPoint);

                string str2 = name + ": " + Console.ReadLine()!;
                byte[] a2 = Encoding.UTF8.GetBytes(str2);
                s2.Send(a2, 0);
                s2.Close();
            }
        }else{
            Console.WriteLine("Don't leave it empty. ");
            goto start;
        }
        




    }
}
