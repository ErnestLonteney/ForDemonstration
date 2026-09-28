using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsipility
{
    internal class GPT5 : Agent
    {
        public override void HandlePrompt(string prompt)
        {
            if (prompt.Length > 500)
            {
                if (NextAgent != null)
                {
                    NextAgent.HandlePrompt(prompt);
                }
                else
                {
                   Console.WriteLine("No agent available to handle the prompt.");
                }    
                
                return;
            }

            Console.WriteLine("GPT-5 is handling the prompt.");
            Console.WriteLine("Spent 200 tokens.");
        }  
    }
}
