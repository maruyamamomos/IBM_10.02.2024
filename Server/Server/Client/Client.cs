using System.Net.Sockets;

public class Client
{
    public Socket Socket { get; set; }

    public Client(Socket socket)
    {
        Socket = socket;
    }
}