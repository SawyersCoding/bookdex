namespace tds.message.types;

public enum MessageType
{
    UNASSIGNED = 0x00,
    SQL_BATCH = 0x01,
    PRE_TDS7_LOGIN = 0x02,
    RCP = 0x03,
    TABULAR_RESULT = 0x04,
    ATTENTION_SIGNAL = 0x06,
    BULK_LOAD_DATA = 0x07,
    FEDERATED_AUTHENTICATION_TOKEN = 0x08,
    TRANSACTION_MANAGER_REQUEST = 0x14,
    LOGIN = 0x10,
    SSPI = 0x11,
    PRE_LOGIN = 0x12
}
