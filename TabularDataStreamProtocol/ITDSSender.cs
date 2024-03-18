using TabularDataStreamProtocol.message;

namespace TabularDataStreamProtocol.tds;

public interface ITDSSender
{
    public void SendMessage(IMessage message);

}