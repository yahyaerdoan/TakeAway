using StackExchange.Redis;

namespace TakeAway.BasketService.Settings.RedisSettings;

public class RedisService
{
    public RedisService(string host, int port)
    {
        _Host = host;
        _Port = port;
    }

    public string _Host { get; set; }
    public int _Port { get; set; }

    private ConnectionMultiplexer _connectionMultiplexer;

    public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_Host}:{_Port}");

    public IDatabase GetDatabase(int db = 1) => _connectionMultiplexer.GetDatabase(0);
}
