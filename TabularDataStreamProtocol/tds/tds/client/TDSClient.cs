using tds.message;
using tds.tds.client.state;
using tds.util;

namespace tds.tds.client;

public class TDSClient : ITDSListener, ITDSSender, IStateMachine<ITDSClientState>
{
    private ITDSClientState state;
    private readonly IFactory<TDSClientStateType, ITDSClientState> factory;

    public IFactory<TDSClientStateType, ITDSClientState> Factory => factory; // So states can access factory.

    public TDSClient()
    {
        factory = new TDSClientStateFactory(this);
        state = factory.Get(TDSClientStateType.INITIAL_TLS_NEGOTIATION);
        state.OnStateActivate();
    }

    public void ChangeState(ITDSClientState state)
    {
        this.state?.OnStateDeactivate();
        this.state = state;
        this.state.OnStateActivate();
    }

    public IMessage Listen()
    {
        return state.Listen();
    }

    public void SendMessage(IMessage message)
    {
        // Actually send message. States will use this.
        throw new NotImplementedException();
    }
}
