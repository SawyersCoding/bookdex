namespace tds.message;

public interface IMessage
{
    public int NumPackets { get; }
    public IPacket GetPacket(int index);
}
