
using tds.message.types;

namespace tds.message.packetbuilder;

public class PreLoginPacketBuilder : IPacketBuilder
{
    private const byte VERSION_LENGTH = 0x06;
    private const byte VERSION_OFFSET = 0x04;
    private const ushort HEADER_LENGTH = 0x08;
    private readonly IPacket packet;

    public PreLoginPacketBuilder()
    {
        packet = new Packet();
    }

    public IPacket Build()
    {
        return packet;
    }

    public IPacketBuilder SetMessageType()
    {
        packet.Type = MessageType.PRE_LOGIN;
        return this;
    }

    public IPacketBuilder SetPacketData()
    {
        packet.Data = [
            (byte)PreLoginOptionToken.VERSION,
            VERSION_LENGTH,
            VERSION_OFFSET,
            (byte)PreLoginOptionToken.TERMINATOR,
            // This is the Version data. Set to zero for now.
            0x00,
            0x00,
            0x00,
            0x00,
            0x00,
            0x00
        ];

        return this;
    }

    public IPacketBuilder SetPacketID()
    {
        packet.PacketID = 0x01; // This value is not currently used according to documentation
        return this;
    }

    public IPacketBuilder SetPacketLength()
    {
        // Must do calculation of number of bytes
        packet.Length = (ushort)(HEADER_LENGTH + packet.Data.Length);
        return this;
    }

    public IPacketBuilder SetPacketSPID()
    {
        packet.SPID = 0x0000; // not currently used.
        return this;
    }

    public IPacketBuilder SetPacketStatus()
    {
        packet.Status = PacketStatus.EOM;
        return this;
    }

    public IPacketBuilder SetPacketWindow()
    {
        packet.Window = 0x00; // not currently used.
        return this;
    }
}
