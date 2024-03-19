
using tds.message;

namespace tds.tds.server.state;

public class TDSServerPreLoginReadyState : AbstractTDSServerState
{
    public TDSServerPreLoginReadyState(TDSServerSession server) : base(server)
    {
    }

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
