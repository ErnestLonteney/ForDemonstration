namespace GameXO;

public class GameXO
{
    private readonly char[,] field = new char[3, 3];

    public char this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < field.Length && j >= 0 && j < field.GetLength(1))
            {
                return field[i, j];
            }
            else
            {
                Console.WriteLine("Wrong position");
            }

            return ' ';
        }
        set
        {
            if (i >= 0 && i < field.Length && j >= 0 && j < field.GetLength(1))
            {
                field[i, j] = value;
                DisplayField();
                CalculateResults();
            }
            else
            {
                Console.WriteLine("Wrong position");
            }
        }
    }

    public void DisplayField()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"|{field[i, j]}|");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 10));
        }
    }

    public bool IsFinished { get; private set; }

    private void CalculateResults()
    {      
        for (int i = 0; i < 3; i++)
        {
            char same = '\0';

            for (int j = 0; j < 3; j++)
            {
                if (field[i, j] == '\0')
                    break;

                if (same == '\0')
                {
                    same = field[i, j];
                }
                else
                if (same != field[i, j])
                {
                    break;
                }

                if (same != '\0' && j == 2)
                {
                    IsFinished = true;
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            char same = '\0';

            for (int j = 0; j < 3; j++)
            {
                if (field[j, i] == '\0')
                    break;

                if (same == '\0')
                {
                    same = field[j, i];
                }
                else
                if (same != field[j, i])
                {
                    break;
                }

                if (same != '\0' && j == 2)
                {
                    IsFinished = true;
                }
            }
        }

        int jj = 0;
        for (int i = 0; i < 3; i++)
        {
            char same = '\0';

            if (field[i, jj] == '\0')
            {
                jj++;
                break;
            }

            if (same == '\0')
            {
                same = field[i, jj];
            }
            else
            if (same != field[i, jj])
            {
                jj++;
                break;
            }

            if (same != '\0' && i == 2)
            {
                IsFinished = true;
            }

            jj++;
        }

        jj = 2;
        for (int i = 0; i < 3; i++)
        {
            char same = '\0';


            if (field[i, jj] == '\0')
            {
                jj--;
                break;
            }

            if (same == '\0')
            {
                same = field[i, jj];
            }
            else
            if (same != field[i, jj])
            {
                jj--;
                break;
            }

            if (same != '\0' && i == 2)
            {
                IsFinished = true;
            }
            jj--;
        }
    }
}
