using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    internal abstract class Command(Executer executer)
    {
        public abstract void Execute();
    }
}
