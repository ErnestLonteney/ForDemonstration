namespace ChainOfResponsipility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var agent1 = new GPTMini();
            var agent2 = new GPT5();
            var agent3 = new CloudSonet();

            agent1.SetNext(agent2);
            agent2.SetNext(agent3);


            while (true)
            {
                Console.WriteLine("Input prompt to agent");
                string prompt = Console.ReadLine() ?? string.Empty;

                if (prompt.Length < 100)
                {
                    agent1.HandlePrompt(prompt);
                }
                else if (prompt.Length < 500)
                {
                    agent2.HandlePrompt(prompt);
                }
                else
                {
                    agent3.HandlePrompt(prompt);
                }
            }

        }
    }
}
