using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneExample
{
    public class CallInfoRecord
    {
        public DateTime DateTime { get; } = DateTime.Now;
        public Contact AnotherContact { get; set; }

        public TimeSpan Duration { get; set; } 

        public bool IsComming { get; set; }

    }
}
