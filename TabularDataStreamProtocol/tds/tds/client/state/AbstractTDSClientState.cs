
using tds.message;

namespace tds.tds.client.state;

public abstract class AbstractTDSClientState : ITDSClientState
{
    private readonly TDSClient client;

    protected TDSClient Client => client;

    protected AbstractTDSClientState(TDSClient client)
    {
        this.client = client;
    }

    public abstract void OnStateActivate();
    public abstract void OnStateDeactivate();
    public abstract IMessage Listen();
    public virtual void SendMessage(IMessage message)
    {
        client.SendMessage(message);
    }
}
