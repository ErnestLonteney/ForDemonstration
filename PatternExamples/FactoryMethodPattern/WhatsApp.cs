namespace FactoryMethodPattern;

class WhatsApp(string port, int id) : Messanger(port, "http")
{
    public int Id { get; } = id;

    public override void Send(string message)
    {
        OpenConnection();
        try
        {
            new HttpClient().Send(new HttpRequestMessage(HttpMethod.Post, $"www.whatsapp.com/message?mess={message}"));
        }
        catch 
        {
        }

        Console.WriteLine($"Send - {message} by Whats App");        
    } 

    private void OpenConnection()
    {
        Console.WriteLine($"Connection has been opened by {Port} port");        
    }
}