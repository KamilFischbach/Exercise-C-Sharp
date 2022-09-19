﻿// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;

using TcpClient client = new TcpClient("127.0.0.1", 5000);

using NetworkStream stream = client.GetStream();

byte[] dataToServer = Encoding.ASCII.GetBytes("Hello from client");
stream.Write(dataToServer, 0, dataToServer.Length);

Thread.Sleep(2000);
byte[] dataFromServer = new byte[1024];
int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
string response = Encoding. ASCII.GetString(dataFromServer, 0, bytesRead);
Console.WriteLine(response);