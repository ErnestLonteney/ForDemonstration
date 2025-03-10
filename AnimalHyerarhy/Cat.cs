using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHyerarhy
{
    class Cat : HomeAnimal
    {
        public Cat(string name) 
            : base(name)
        {
        }

        public override void MakeVoice() // from Animal class
        {
            Console.WriteLine("Myau-Myau");
        }

        public override void Play() // From Home Animal
        {
            Console.WriteLine("Play with ball");
        }

        public void SleepWithYou()
        {
            Console.WriteLine("I`m sleeping with you");
        }

    }
}
