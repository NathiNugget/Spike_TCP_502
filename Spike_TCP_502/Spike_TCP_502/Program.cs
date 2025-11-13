// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;

// This we like
TcpClient tcpClient = new TcpClient("192.168.123.100", 502);
Console.WriteLine("Hello, World!");

tcpClient.Close();
tcpClient = null; 


// This we do not like
tcpClient = new TcpClient("192.168.123.100",501);
Console.WriteLine("Hello, World!");

tcpClient.Close();
