using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHyerarhy
{
    abstract class WildAnimal : Animal
    {
        protected WildAnimal(string name) 
            : base(name)
        {
        }

        public string Region { get; set; }

        public abstract void Hunt();
    }
}
