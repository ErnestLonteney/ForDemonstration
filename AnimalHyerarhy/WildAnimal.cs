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

        public Animal[] Victams { get; set; }
        public string Region { get; set; }  
    }
}
