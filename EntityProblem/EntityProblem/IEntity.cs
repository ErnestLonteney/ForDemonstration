using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProblem
{
    interface IEntity<T>
    {
        T Id { get; set; }
        string Name { get; set; }    
    }
}
