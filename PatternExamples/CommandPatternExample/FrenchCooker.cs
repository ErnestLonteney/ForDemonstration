using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    internal class FrenchCooker : Executer
    {
        public override void MakeChicken(byte countPorcions)
        {
            for (int i = 0; i < countPorcions; i++)
                Console.WriteLine("French cooker cooks chicken");
        }

        public override void MakeFish(byte countPorcions)
        {
            Console.WriteLine("I cannot cook fish");
        }

        public override void MakeRice(byte countPorcions)
        {
            for (int i = 0; i < countPorcions; i++)
                Console.WriteLine("French cooker cooks rice");
        }
    }
}
