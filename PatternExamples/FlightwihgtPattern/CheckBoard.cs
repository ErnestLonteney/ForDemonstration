using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlightwihgtPattern
{
    internal class CheckBoard
    {
        private CheckFigure?[,] _grid = new CheckFigure[8, 8];

        public CheckFigure this[int x, int y]
        {
            get { return _grid[x, y]; }
        }


        public void MoveFigure(int fromX, int fromY, int toX, int toY)
        {
            CheckFigure figure = _grid[fromX, fromY];
            if (figure != null)
            {
                figure.Move();
                _grid[toX, toY] = figure;
                _grid[fromX, fromY] = null;
            }
        }


        public void Restart()
        {
            CheckFigureFactory checkFigureFactory = new CheckFigureFactory();

            for (int i = 0; i < 8; i++)
            {
                _grid[1, i] = checkFigureFactory.CreateFigure("Pawn", CheckColors.White);
            }


            for (int i = 0; i < 8; i++)
            {
                _grid[6, i] = checkFigureFactory.CreateFigure("Pawn", CheckColors.Black);
            }
        }


        public void Display()
        {
            Console.WriteLine(new String('=', 80));

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    CheckFigure figure = _grid[i, j];
                    if (figure != null)
                    {
                        Console.Write($"[{figure.Color}-{figure.Name}] ");
                    }
                    else
                    {
                        Console.Write("[ ] ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new String('=', 80));
        }
    }
}
