
namespace tds.tds.server.state;

public enum TDSServerStateType
{
    INITIAL,
    TLS_NEGOTIATION,
    PRE_LOGIN_READY,
    LOGIN_READY,
    SPNEGO_NEGOTIATION,
    LOGGED_IN,
    REQUEST_EXECUTION,
    FINAL
}
