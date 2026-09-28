namespace ChainOfResponsipility
{
    internal class CloudSonet : Agent
    {
        public override void HandlePrompt(string prompt)
        {
            Console.WriteLine("CloudSonet handling prompt: " + prompt);
            Console.WriteLine("Spent 500 tokens.");
        }   
    }
}
