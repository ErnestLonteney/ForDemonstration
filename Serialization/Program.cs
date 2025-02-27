using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main()
        {
            User[] users =
            [
                new ("kevin97", "qwerty"),
                new ("lily34", "12345"),
                new ("sam56", "password")
            ];

            string result = JsonSerializer.Serialize(users);
            Console.WriteLine(result);
            File.WriteAllText("users.json", result);

            Console.WriteLine(new string('-', 50));

            string json = File.ReadAllText("users.json");
            User[] deserealizedUsers = JsonSerializer.Deserialize<User[]>(json) ?? [];

            foreach (User user in deserealizedUsers)
            {
                Console.WriteLine(user.Login);
            }

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].Equals(deserealizedUsers[i]));
            }
        }
    }
}
