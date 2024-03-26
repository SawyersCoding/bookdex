
namespace tds.message.packetbuilder;

public interface IPacketBuilder
{
    public IPacketBuilder SetMessageType();
    public IPacketBuilder SetPacketStatus();
    public IPacketBuilder SetPacketLength();
    public IPacketBuilder SetPacketSPID();
    public IPacketBuilder SetPacketID();
    public IPacketBuilder SetPacketWindow();
    public IPacketBuilder SetPacketData();
    public IPacket Build();
}
