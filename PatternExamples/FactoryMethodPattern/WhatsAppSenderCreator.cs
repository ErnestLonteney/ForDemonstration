namespace FactoryMethodPattern;

class WhatsAppSenderCreator : SenderCreator
{
    // Fabric method
    public override Messanger CreateSender(string port)
    {
        return new WhatsApp(port, 567);
    }
}