using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyExample
{
    public class SpaceModule : ISpaceModule
    {
        public required Guid SeriaNumber { get; init; } 

        public void LaunchEngine()
        {
            Console.WriteLine("Space module launching...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Space module stopping...");
        }

        public void HyperJump()
        {
            Console.WriteLine("Space module performing hyper jump...");
        } 

        public void ShootingLaser()
        {
            Console.WriteLine("Space module shooting laser...");
        }

    }
}
