using tds.message.types;

namespace tds.message.packetbuilder;

public class Packet : IPacket
{
    public MessageType Type { get; set; }
    public PacketStatus Status { get; set; }
    public ushort Length { get; set; }
    public ushort SPID { get; set; }
    public byte PacketID { get; set; }
    public byte Window { get; set; }
    public byte[] Data { get; set; }

    public Packet()
    {
        Type = MessageType.UNASSIGNED;
        Status = PacketStatus.NORMAL;
        Length = 0;
        SPID = 0;
        PacketID = 0;
        Window = 0;
        Data = [];
    }
}
