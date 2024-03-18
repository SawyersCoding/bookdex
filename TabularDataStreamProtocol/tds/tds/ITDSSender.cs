using tds.message;

namespace tds.tds;

public interface ITDSSender
{
    public void SendMessage(IMessage message);
}
