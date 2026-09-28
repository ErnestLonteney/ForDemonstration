using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsipility
{
    internal abstract class Agent
    {
        public Agent? NextAgent { get; set; }
        public abstract void HandlePrompt(string prompt);
        public void SetNext(Agent nextAgent)
        {
            NextAgent = nextAgent;
        }
    }
}
