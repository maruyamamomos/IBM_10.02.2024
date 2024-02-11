using System.Buffers.Binary;
using System.Text;

public static class PacketReader
{
    public static byte[] Buffer { get; set; }
    public static int Position { get; set; }

    static int _defaultBufferSize = 512;

    static int _headerSize = 5;

    static PacketReader()
    {
        Buffer = new byte[_defaultBufferSize];
        Position = _headerSize;
    }

    public static void ResetBuffer()
    {
        Buffer = new byte[_defaultBufferSize];
        Position = 0;
    }

    public static void ResizeBuffer()
    {
        var newBuffer = new byte[Buffer.Length * 2];

        Buffer.AsSpan(0, Buffer.Length).CopyTo(newBuffer);
        Buffer = newBuffer;
    }

    public static byte ReadByte()
    {
        Position += sizeof(byte);
        return Buffer[Position];
    }

    public static int ReadInt()
    {
        var value = BinaryPrimitives.ReadInt32BigEndian(Buffer.AsSpan(Position, sizeof(int)));

        Position += sizeof(int);
        return value;
    }

    public static string ReadString()
    {
        var length = ReadInt();

        var value = Encoding.UTF8.GetString(Buffer.AsSpan(Position, length));

        Position += length;
        return value;
    }
}