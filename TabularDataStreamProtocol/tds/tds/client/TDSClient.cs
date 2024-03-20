using tds.message;
using tds.tds.client.state;
using tds.util;
using System.Net;
using System.Net.Sockets;

namespace tds.tds.client;

public class TDSClient : ITDSListener, ITDSSender, IStateMachine<ITDSClientState>
{
    private readonly string ip;
    private readonly int port;
    private readonly TcpClient tcpClient;
    private readonly NetworkStream stream;
    private readonly IFactory<TDSClientStateType, ITDSClientState> factory;
    private ITDSClientState state;

    public IFactory<TDSClientStateType, ITDSClientState> Factory => factory; // So states can access factory.
    public string IP => ip;
    public int Port => port;
    

    public TDSClient(string ip, int port)
    {
        // Establish regular TCP connection.
        tcpClient = new TcpClient(AddressFamily.InterNetwork);
        tcpClient.Connect(ip, port);
        stream = tcpClient.GetStream();

        // Initialize rest of client if successful connection is established.
        this.ip = ip;
        this.port = port;
        factory = new TDSClientStateFactory(this);
        state = factory.Get(TDSClientStateType.INITIAL_TLS_NEGOTIATION);
        state.OnStateActivate();
    }

    public void ChangeState(ITDSClientState state)
    {
        this.state.OnStateDeactivate();
        this.state = state;
        this.state.OnStateActivate();
    }

    public IMessage Listen()
    {
        return state.Listen();
    }

    public void SendMessage(IMessage message)
    {
        IPacket packet;
        byte[] packetBytes;
        for (int i = 0; i < message.NumPackets; i++)
        {
            // Extract data from next packet
            packet = message.GetPacket(i);
            packetBytes = packet.GetBytes();

            // Send next packet containing next part of message
            Console.WriteLine("Sending packet (" + (i + 1) + ") of message...");
            stream.Write(packetBytes, 0, packetBytes.Length);
        }
    }
}
