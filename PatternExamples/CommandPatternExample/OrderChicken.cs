using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    internal class OrderChicken(Executer executer, byte countPorsions) : Command(executer)
    {
        public override void Execute()
        {
            executer.MakeChicken(countPorsions);
        }
    }
}
