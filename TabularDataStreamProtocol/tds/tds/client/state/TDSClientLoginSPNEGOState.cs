
using tds.message;

namespace tds.tds.client.state;

public class TDSClientLoginSPNEGOState : AbstractTDSClientState
{
    public TDSClientLoginSPNEGOState(TDSClient client) : base(client) { }

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
