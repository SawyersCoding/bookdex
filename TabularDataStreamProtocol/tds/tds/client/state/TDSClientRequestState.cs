
using tds.message;

namespace tds.tds.client.state;

public class TDSClientRequestState : AbstractTDSClientState
{
    public TDSClientRequestState(TDSClient client) : base(client) { }

    public override void OnStateActivate()
    {
        throw new NotImplementedException();
    }

    public override void OnStateDeactivate()
    {
        throw new NotImplementedException();
    }
    public override IMessage Listen()
    {
        throw new NotImplementedException();
    }
}
