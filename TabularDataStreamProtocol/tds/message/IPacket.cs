
using tds.message.types;

namespace tds.message;

public interface IPacket
{
    // Header
    public MessageType Type { get; set; }
    public PacketStatus Status { get; set; }
    public ushort Length { get; set; }
    public ushort SPID { get; set; }
    public byte PacketID { get; set; }
    public byte Window { get; set; }

    // Packet Body
    public byte[] Data { get; set; }
}
