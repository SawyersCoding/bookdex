namespace tds.tds.client.state;

public enum TDSClientStateType
{
    INITIAL_TLS_NEGOTIATION,
    PRE_LOGIN,
    LOGIN_SPNEGO,
    LOGGED_IN,
    REQUEST,
    ATTENTION,
    FINAL
}
