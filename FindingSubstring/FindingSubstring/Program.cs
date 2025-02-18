namespace FindingSubstring
{
    internal class Program
    {
        static bool IsExistSubsting(string source, string substring)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                check:
                if (source[i] == substring[count])
                {
                    count++;
                    if (count == substring.Length)
                        return true;
                    
                    continue;
                }

                if (count > 0)
                {
                    count = 0;
                    goto check;
                }
            }

            return false;
        }


        static bool IsExistSubsting2(string source, string substring)
        {
            for (int i = 0; i < source.Length - substring.Length; i++)
            {
                int count = 0;

                while (count < substring.Length && source[i + count] == substring[count])
                {
                    count++;
                }

                if (count == substring.Length)
                    return true;
            }

            return false;
        }

        static void Main()
        {
            var result = "apple".Contains("plen"); 
            Console.WriteLine(result);
        }
    }
}
