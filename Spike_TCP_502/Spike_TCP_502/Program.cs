// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;



TcpClient tcpClient = new TcpClient("192.168.123.100",501);
Console.WriteLine("Hello, World!");

tcpClient.Close();
