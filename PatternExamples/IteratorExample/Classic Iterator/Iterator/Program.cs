using System;

// Iterator Design Pattern.

namespace Iterator
{    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Aggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Element A";
            aggregate[1] = "Element B";
            aggregate[2] = "Element C";
            aggregate[3] = "Element D";

            Iterator iterator = aggregate.CreateIterator();


            Console.WriteLine("Перший елемент колекції:");

            object element = iterator.First();
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Ітерація з колекції:");            
            while (!iterator.IsDone())
            {
                element = iterator.Next();
                Console.WriteLine(element);
            }

            Iterator iterator2 = aggregate.CreateIterator();
            Console.WriteLine("Ітерація з колекції:");
            while (!iterator2.IsDone())
            {
                element = iterator2.Next();
                Console.WriteLine(element);
            }



            // Delay.
            Console.ReadKey();
        }
    }
}
