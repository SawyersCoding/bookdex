
namespace tds.tds.client.state;

public interface ITDSClientState : ITDSListener, ITDSSender
{
    public void OnStateActivate();
    public void OnStateDeactivate();
}
