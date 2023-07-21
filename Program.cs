using System.Threading.Channels;
using System.Linq;
using System.Text;

namespace ForDemonstration
{
    internal class Program
    {
        static void ChangeArray(ref int[] array, int n)
        {
            array[0] = 1;
            array[1] = 2;
            
            array = new int[1000];
        }

        static void Main()
        {
            int number = 2;
            int[] array; // chefbef283892

            array = new int[2] { 1, 2 };

            ChangeArray(ref array, number);

            bool flag = true, flag2 = false;    

            flag &= flag2; // flag = flag && flag2 
        }
    }
}