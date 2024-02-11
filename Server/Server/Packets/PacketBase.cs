public abstract class OutgoingPacket
{
    public abstract PacketType PacketType { get; }
    public virtual void Serialize()
    {
        PacketWriter.Position = 0;

        PacketWriter.Write((byte)PacketType);
        PacketWriter.Write(PacketWriter.Buffer.Length);
    }
}

public abstract class IncomingPacket
{
    public abstract PacketType PacketType { get; set; }
    public abstract int PacketLength { get; set; }

    public virtual void Deserialize()
    {
        PacketReader.Position = 0;

        PacketType = (PacketType)PacketReader.ReadByte();
        PacketLength = PacketReader.ReadInt();
    }
}

public enum PacketType : byte
{
    Init
}