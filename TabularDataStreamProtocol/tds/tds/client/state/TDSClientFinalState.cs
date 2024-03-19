
using tds.message;

namespace tds.tds.client.state;

public class TDSClientFinalState : AbstractTDSClientState
{
    public TDSClientFinalState(TDSClient client) : base(client) { }

    public override IMessage Listen()
    {
        throw new NotImplementedException();
    }

    public override void OnStateActivate()
    {
        throw new NotImplementedException();
    }

    public override void OnStateDeactivate()
    {
        throw new NotImplementedException();
    }
}
