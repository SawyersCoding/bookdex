
using tds.util;

namespace tds.tds.server.state;

public class TDSServerStateFactory : IFactory<TDSServerStateType, ITDSServerState>
{
    private readonly IDictionary<TDSServerStateType, ITDSServerState> typeToStateMap;

    public TDSServerStateFactory(TDSServerSession server)
    {
        typeToStateMap = new Dictionary<TDSServerStateType, ITDSServerState>()
        {
            // Add new pairs here
            { TDSServerStateType.INITIAL, new TDSServerInitialState(server) },
            { TDSServerStateType.TLS_NEGOTIATION, new TDSServerTLSNegotiationState(server) },
            { TDSServerStateType.PRE_LOGIN_READY, new TDSServerPreLoginReadyState(server) },
            { TDSServerStateType.LOGIN_READY, new TDSServerLoginReadyState(server) },
            { TDSServerStateType.SPNEGO_NEGOTIATION, new TDSServerSPNEGONegotiationState(server) },
            { TDSServerStateType.LOGGED_IN, new TDSServerLoggedInState(server) },
            { TDSServerStateType.REQUEST_EXECUTION, new TDSServerRequestExecutionState(server) },
            { TDSServerStateType.FINAL, new TDSServerFinalState(server) },
        };
    }

    public ITDSServerState Get(TDSServerStateType key)
    {
        if (typeToStateMap.TryGetValue(key, out ITDSServerState? value))
        {
            return value;
        }
        else
        {
            throw new ArgumentException("Given " + nameof(key) + " does not exist in factory.");
        }
    }
}
