using tds.message;

namespace tds.tds.server;

public class TDSServer : ITDSListener
{
    public IMessage Listen()
    {
        // upon receiving a request, create a new server session to delegate handling the request asyncronously.
        throw new NotImplementedException();
    }
}
