using tds.util;

namespace tds.tds.client.state;

public class TDSClientStateFactory : IFactory<TDSClientStateType, ITDSClientState>
{
    private readonly IDictionary<TDSClientStateType, ITDSClientState> typeToStateMap;

    public TDSClientStateFactory(TDSClient client)
    {
        typeToStateMap = new Dictionary<TDSClientStateType, ITDSClientState>()
        {
            { TDSClientStateType.INITIAL_TLS_NEGOTIATION, new TDSClientInitialTLSNegotiationState(client) },
            { TDSClientStateType.PRE_LOGIN, new TDSClientPreLoginState(client) },
            { TDSClientStateType.LOGIN_SPNEGO, new TDSClientLoginSPNEGOState(client) },
            { TDSClientStateType.LOGGED_IN, new TDSClientLoggedInState(client) },
            { TDSClientStateType.REQUEST, new TDSClientRequestState(client) },
            { TDSClientStateType.ATTENTION, new TDSClientAttentionState(client) },
            { TDSClientStateType.FINAL, new TDSClientFinalState(client) }
        };
    }

    public ITDSClientState Get(TDSClientStateType key)
    {
        if (typeToStateMap.TryGetValue(key, out ITDSClientState? value))
        {
            return value;
        }
        else
        {
            throw new ArgumentException("Given " + nameof(key) + " does not exist in factory.");
        }
    }
}
