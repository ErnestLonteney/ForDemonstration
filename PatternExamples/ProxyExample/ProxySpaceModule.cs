namespace ProxyExample
{
    class ProxySpaceModule : ISpaceModule
    {
        public List<string> LogJournal { get; set; } = new List<string>();

        private const string Password = "1234";

        private readonly string password;
        private readonly SpaceModule spaceModule;

        public string Rank { get; set; }

        public string Name { get; set; }

        public ProxySpaceModule(string rang, string name, string password)
        {
            Rank = rang;
            Name = name;
            this.password = password;
            spaceModule = new SpaceModule() { SeriaNumber = Guid.NewGuid() };
        }

        public void LaunchEngine()
        {
           LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} is trying to launch engine...");
           if (password == Password && Rank == "Commander")
           {
                spaceModule.LaunchEngine();
            }
           else
           {
                LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} has failed to launch engine. Wrong password or insufficient rank.");
           }
        }

        public void StopEngine()
        {
            LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} is trying to stop engine...");
            spaceModule.StopEngine();
        }

        public void HyperJump()
        {
            LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} is trying to perform hyper jump...");
            if (Rank == "Commander" || Rank == "ChiffOfficer")
            {
                spaceModule.HyperJump();
            }
            else
            {
                LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} has failed to perform hyper jump. Wrong password or insufficient rank.");
            }
        }

        public void ShootingLaser()
        {
            LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} is trying to shoot laser...");
            if (password == Password)
            {
                spaceModule.ShootingLaser();
            }
            else
            {
                LogJournal.Add($"[{DateTime.Now}] {Rank} {Name} has failed to shoot laser. Wrong password or insufficient rank.");
            }
        }  
        
        public void ShowLogJournal()
        {
            Console.WriteLine("Log Journal:");
            foreach (var log in LogJournal)
            {
                Console.WriteLine(log);
            }
        }
    }
}
