using tds.message;
using tds.tds.server.state;
using tds.util;

namespace tds.tds.server;

public class TDSServerSession : ITDSListener, ITDSSender, IStateMachine<ITDSServerState>
{
    private ITDSServerState state;

    public void ChangeState(ITDSServerState state)
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
