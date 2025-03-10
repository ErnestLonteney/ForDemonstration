using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHyerarhy
{
    abstract class HomeAnimal : Animal
    {
        protected HomeAnimal(string name) 
            : base(name)
        {
        }

        public string Nutrition { get; set; }

        public abstract void Play();
    }
}
