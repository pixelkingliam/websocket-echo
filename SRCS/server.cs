using System;
using WebSocketSharp;
using WebSocketSharp.Server;
class Echo : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Send(e.Data);
        Console.WriteLine(e.Data);
    }
}
class Server
{
    public static void Main(String[] args)
    {
        var wssv = new WebSocketServer(System.Net.IPAddress.Any, int.Parse(args[0]));
        wssv.AddWebSocketService<Echo>("/echo");
        wssv.Start();
        Console.ReadKey();
    }

}