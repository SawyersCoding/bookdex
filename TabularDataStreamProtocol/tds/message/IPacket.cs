
namespace tds.message;

public interface IPacket
{
    public IPacketHeader Header { get; }

    public byte[] GetBytes();
}
