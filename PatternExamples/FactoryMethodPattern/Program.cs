namespace FactoryMethodPattern;

internal class Program
{
    private static void SendMessage(SenderCreator sender, string message)
    {
        var messanger = sender.CreateSender("3445");
        messanger.Send(message);
    }

    public static void Main()
    {
        SenderCreator[] senders = [ new WhatsAppSenderCreator(), new TelegramSenderCreator()  ];

        foreach (var sender in senders)
        {
            SendMessage(sender, "Hello!");                
        }
    }
}