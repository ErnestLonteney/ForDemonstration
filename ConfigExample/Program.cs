using Microsoft.Extensions.Configuration;

namespace ConfigExample
{
    internal class Program
    {
        static void Greeting(string name, IConfiguration config)
        {
            string color = config["Color"] ?? "White";
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            Console.WriteLine($"{name.ToUpper()}!");
            string? additionalMessage = config["AdditionalMessage"] ?? null;
            if (additionalMessage != null)
            {
                Console.WriteLine(additionalMessage);
            }

            Console.ResetColor();
        }

        static void Main()
        {

            var configBuilder = new ConfigurationBuilder();
            IConfiguration config = configBuilder
                .AddJsonFile("Configuration.json")
                .AddXmlFile("Config2.xml")
                .Build();

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine() ?? string.Empty;
            Greeting(name, config);

            Console.ReadKey();
        }
    }
}
