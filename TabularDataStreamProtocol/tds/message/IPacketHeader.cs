using tds.datatypes;

namespace tds.message;

public interface IPacketHeader
{
    public MessageType MessageType { get; }
    public PacketStatus Status { get; }
    public Byte2 Length { get; }
    public Byte2 SPID { get; }
    public byte PacketID { get; }
    public byte Window {  get; }
}
