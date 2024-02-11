using System.Buffers.Binary;
using System.Text;

public static class PacketWriter
{
    public static byte[] Buffer { get; set; }
    public static int Position { get; set; }

    static int _defaultBufferSize = 512;

    static int _headerSize = 5;

    static PacketWriter()
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

    public static void Write(byte value)
    {
        if(Position + sizeof(byte) > Buffer.Length)
            ResizeBuffer();

        Buffer[Position] = value;
        Position += sizeof(byte);
    }

    public static void Write(int value)
    {
        if (Position + sizeof(int) > Buffer.Length)
            ResizeBuffer();

        BinaryPrimitives.WriteInt32BigEndian(Buffer.AsSpan(Position, sizeof(int)), value);
        Position += sizeof(int);
    }

    public static void Write(string value)
    {
        if(Position + (value.Length * sizeof(char)) > Buffer.Length)
            ResizeBuffer();

        var bytes = Encoding.UTF8.GetBytes(value);

        bytes.CopyTo(Buffer, Position);
        Position += bytes.Length;
    }
}