using tds.message;

namespace tds.tds;

public interface ITDSListener
{
    public IMessage Listen();
}
