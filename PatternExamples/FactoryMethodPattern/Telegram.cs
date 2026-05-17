namespace FactoryMethodPattern;

class Telegram : Messanger
{
     private readonly HttpClient httpClient;

    public Telegram(string port)
        :base(port, "http")
    {
         var handler = new HttpClientHandler();
         httpClient = new HttpClient(handler);
    }

    public override void Send(string message)
    {
        OpenConnection();
        try
        {
            httpClient.Send(new HttpRequestMessage(HttpMethod.Post, message));
        } 
        catch  
        {
        }

        Console.WriteLine($"Send - {message} by Telegram");        
    } 

    private void OpenConnection()
    {
        Console.WriteLine($"Connection has been opened by {Port} port");        
    }
}