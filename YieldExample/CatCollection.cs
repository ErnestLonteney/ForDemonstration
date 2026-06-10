using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace YieldExample
{
    class CatCollection : IEnumerable<Cat>, IEnumerator<Cat>
    {
        private List<Cat> cats = new List<Cat>();

        private int currentCatIndex = -1;

        public Cat Current => cats[currentCatIndex];

        object IEnumerator.Current => Current;

        public void Add(Cat cat)
        {
            cats.Add(cat);
        }

        public void Dispose()
        {
        }

        public IEnumerator<Cat> GetEnumerator()
        {
            if (DateTime.Now.Hour < 9 || DateTime.Now.Hour > 17)
            {
                yield break;
            }

            foreach (var cat in cats.Where(c => c.Level > 50))
            {
                yield return cat;
            }

        }

        public bool MoveNext()
        { 
            if (cats.Any(cats => cats.Level > 50) && currentCatIndex <= cats.Count - 1)
            {
                for (int i = currentCatIndex + 1; i < cats.Count; i++)
                {
                    if (cats[i].Level > 50)
                    {
                        currentCatIndex = i;
                        return true;
                    }
                }
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            currentCatIndex = -1;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
