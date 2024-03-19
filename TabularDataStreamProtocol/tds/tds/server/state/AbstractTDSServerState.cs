
using tds.message;

namespace tds.tds.server.state;

public abstract class AbstractTDSServerState : ITDSServerState
{
    private readonly TDSServerSession server;

    protected TDSServerSession Server => server;

    protected AbstractTDSServerState(TDSServerSession server)
    {
        this.server = server;
    }

    public abstract void OnStateActivate();
    public abstract void OnStateDeactivate();
    public abstract IMessage Listen();
    public virtual void SendMessage(IMessage message)
    {
        server.SendMessage(message);
    }
}
