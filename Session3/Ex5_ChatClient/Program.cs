// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;

TcpClient client = new TcpClient("127.0.0.1", 5000);
NetworkStream stream = client.GetStream();

Thread t1 = new Thread(() => Writing());
Thread t2 = new Thread(() => Read());
t1.Start();
t2.Start();


void Writing()
{
    Console.WriteLine("Write your text here('exit' to end the connection):");
    while (true)
    {
        string x = Console.ReadLine();
        string xLower = x.ToLower();
        if (xLower.Equals("exit"))
        {
            break;
        }
        byte[] dataToServer = Encoding.ASCII.GetBytes(x);
        stream.Write(dataToServer, 0, dataToServer.Length);
        
    }
    stream.Close();
    client.Close();
}

void Read()
{
    while (true)
    {
        byte[] dataFromServer = new byte[4096];
        int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
        string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
        Console.WriteLine(response);
    }
}
