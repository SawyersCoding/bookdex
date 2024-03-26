
namespace tds.message.types;

public enum PreLoginOptionToken
{
    VERSION = 0x00,
    ENCRYPTION = 0x01,
    INST_OPT = 0x02,
    THREAD_ID = 0x03,
    MARS = 0x04,
    TRACE_ID = 0x05,
    FED_AUTH_REQUIRED = 0x06,
    NONCE_OPT = 0x07,
    TERMINATOR = 0xFF
}
