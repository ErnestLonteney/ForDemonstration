namespace FactoryMethodPattern;

abstract class SenderCreator
{
    // Abstract Fabric method
    public abstract Messanger CreateSender(string port);
}