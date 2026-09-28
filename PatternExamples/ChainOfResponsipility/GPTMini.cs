namespace ChainOfResponsipility
{
    internal class GPTMini : Agent
    {
        public override void HandlePrompt(string prompt)
        {
            if (prompt.Length > 100)
            {
                if (NextAgent != null)
                {
                    NextAgent.HandlePrompt(prompt);
                }
                else
                {
                    Console.WriteLine("No agent available to handle the prompt.");
                }
                
                return;
            }

            Console.WriteLine("GPTMini handling prompt: " + prompt);
            Console.WriteLine("Spent 100 tokens.");
        }
    }
}
