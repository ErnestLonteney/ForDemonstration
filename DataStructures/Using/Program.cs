using DataStructures;

namespace Using
{
    internal class Program
    {
        static void Main()
        {
            var list = new ExtraLinkedList<int>();

            var f = list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(4);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            var linkedList = new LinkedList<int>();

            var one = linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);



            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
