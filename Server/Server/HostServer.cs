using System.Net;
using System.Net.Sockets;

public static class HostServer
{
    public static Socket Socket { get; }
    public static IPEndPoint IPEndPoint { get; }
    public static HashSet<Client> Clients { get; private set; }
    public static bool AcceptNewClients = false;

    const int _port = 3500;

    static HostServer()
    {
        Socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint = new(IPAddress.Loopback, _port);
        Clients = new HashSet<Client>();

        InitializeSocket();
    }

    public static void InitializeSocket()
    {
        Socket.Bind(IPEndPoint);
        Socket.Listen();

        AcceptNewClients = true;

        Console.WriteLine("Socket Initialized and Listening!");

        AcceptClients();
    }

    static void AcceptClients()
    {
        while(AcceptNewClients)
        {
            var newClient = new Client(Socket.Accept());

            Console.WriteLine($"{newClient.Socket.RemoteEndPoint} is trying to connect!");

            foreach (var client in Clients)
            {
                if (client.Socket.RemoteEndPoint == newClient.Socket.RemoteEndPoint)
                {
                    KickClient(newClient);
                    return;
                }
            }

            Clients.Add(newClient);
            Console.WriteLine($"{newClient.Socket.RemoteEndPoint} has successfully connected!");

            Task.Run(() => HandleNewClient(newClient));
        }

        AcceptClients();
    }

    static void HandleNewClient(Client newClient)
    {
        Packet.Send<Initialize>(newClient);
    }

    static void KickClient(Client client)
    {
        Clients.Remove(client);
        client.Socket.Close();
    }
}