namespace FactoryMethodPattern;

abstract class Messanger(string port, string protocol)
{
    public string Port { get; } = port;
    public string Protocol { get; } = protocol;

    public abstract void Send(string message);
}