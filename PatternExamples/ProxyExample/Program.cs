namespace ProxyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISpaceModule proxySpaceModule = new ProxySpaceModule("Commander", "Apollo", "1234");
            proxySpaceModule.LaunchEngine();
            proxySpaceModule.HyperJump();
            proxySpaceModule.ShootingLaser();
            proxySpaceModule.StopEngine();

            Console.WriteLine(new string('-', 50));

            ISpaceModule proxySpaceModule2 = new ProxySpaceModule("StaffOfficer", "Apollo", "1234");
            proxySpaceModule2.LaunchEngine();
            proxySpaceModule2.HyperJump();
            proxySpaceModule2.ShootingLaser();
            proxySpaceModule2.StopEngine();

            Console.WriteLine(new string('-', 50));

            ISpaceModule proxySpaceModule3 = new ProxySpaceModule("Officer", "Apollo", null);
            proxySpaceModule3.LaunchEngine();
            proxySpaceModule3.HyperJump();
            proxySpaceModule3.ShootingLaser();
            proxySpaceModule3.StopEngine();

            Console.WriteLine(new string('-', 50));

            ProxySpaceModule proxySpaceModule4 = (ProxySpaceModule)proxySpaceModule3;


            proxySpaceModule4.ShowLogJournal();
        }
    }
}
