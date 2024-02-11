public static class Packet
{
    public static void Send<T>(Client client) where T : OutgoingPacket, new()
    {
        T instance = new();

        instance.Serialize();
        client.Socket.Send(PacketWriter.Buffer);

        PacketWriter.ResetBuffer();
    }
}