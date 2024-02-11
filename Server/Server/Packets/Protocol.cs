public class Initialize : OutgoingPacket
{
    public override PacketType PacketType => PacketType.Init;

    public override void Serialize()
    {
        base.Serialize();

        //From here you create individual behaviour per packet type
        //For this application we want to send our cached data and send it to the new recipient
    }
}