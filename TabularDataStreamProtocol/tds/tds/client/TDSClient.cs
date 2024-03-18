using tds.message;
using tds.tds.client.state;
using tds.util;

namespace tds.tds.client;

public class TDSClient : ITDSListener, ITDSSender, IStateMachine<ITDSClientState>
{
    private ITDSClientState state;

    public TDSClient()
    {

    }

    public void ChangeState(ITDSClientState state)
    {
        this.state.OnStateDeactivate();
        this.state = state;
        this.state.OnStateActivate();
    }

    public IMessage Listen()
    {
        throw new NotImplementedException();
    }

    public void SendMessage(IMessage message)
    {
        throw new NotImplementedException();
    }
}
