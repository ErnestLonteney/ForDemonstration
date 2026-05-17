using System;

namespace FactoryMethodPattern;

class TelegramSenderCreator : SenderCreator
{
    // Abstract Fabric method
    public override Messanger CreateSender(string port)
    {
        return new Telegram(port);
    }  
}