namespace tds.message.types;

public enum PacketStatus
{
    NORMAL = 0x00,
    EOM = 0x01,
    IGNORE_THIS_EVENT = 0x02,
    RESET_CONNECTION = 0x08,
    RESET_CONNECTION_SKIP_TRAN = 0X10
}
