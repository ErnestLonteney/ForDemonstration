using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll
{
    internal class ResultCollection : IEnumerable<double>
    {
        private readonly List<double> _results;

        public ResultCollection()
        {
            _results = new List<double>();    
        }

        public IEnumerator<double> GetEnumerator()
        {
           return _results.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _results.GetEnumerator();
        }

        public void Add(double value) 
        {
            _results.Add(value);
        }
    }
}
