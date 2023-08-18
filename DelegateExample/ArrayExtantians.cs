namespace DelegateExample
{
    delegate bool FilterDelegate(int n);
    static class ArrayExtantians
    {
        public static int[] Filter(this int[] array, FilterDelegate filterMethod)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (filterMethod.Invoke(array[i]))
                    count++;
            }

            if (count == 0)
                return Array.Empty<int>();

            int[] temptArray = new int[count];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (filterMethod.Invoke(array[i]))
                {
                    temptArray[j++] = array[i];
                }
            }

            return temptArray;  
        }
    }
}
