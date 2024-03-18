
namespace tds.tds.server.state;

public interface ITDSServerState : ITDSListener, ITDSSender
{
    public void OnStateActivate();
    public void OnStateDeactivate();
}
