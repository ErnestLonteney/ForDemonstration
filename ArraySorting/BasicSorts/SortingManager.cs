namespace BasicSorts
{
    public static class SortingManager
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public static void SelectionSort(int[] array)
        {
            int GetMinElementIndex(int startIndex)
            {
                int currentMin = array[startIndex];
                int index = startIndex;

                for (int i = startIndex; i < array.Length; i++)
                    if (array[i] < currentMin)
                    {
                        currentMin = array[i];
                        index = i;
                    }

                return index;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                var minIndex = GetMinElementIndex(i);
                if (i != minIndex)
                {
                    Swap(array, i, minIndex);
                }
            }
        }

        public static void InsertingSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int candidate = array[i];
                int index = i;

                while (index > 0 && array[index - 1] > candidate)
                {
                    array[index] = array[--index];
                }


                if (index != i)
                    array[index] = candidate;
            }
        }

        static void Swap(int[] array, int a, int b)
        {
            var buf = array[a];
            array[a] = array[b];
            array[b] = buf;
        }
    }
}
