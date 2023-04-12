using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GameOfLife
    {
        private static int width;
        private static int height;
        private bool[,] field;
        private bool[,] newField;

        public GameOfLife()
        {
            Random rnd = new Random();
            height = rnd.Next(3, 10);
            width = rnd.Next(3, 10);
            field = new bool[height, width];
            newField = new bool[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = NextBool();
                }
            }
            PrintField();
        }
        private bool NextBool()
        {
            Random rnd = new Random();
            int truePercentage = 50;
            return rnd.NextDouble() < truePercentage / 100.0;
        }

        private int countNeighbors(int y, int x)
        {
            int count = 0;
            for (int i = y-1; i <= y+1; i++)
            {
                for (int j = x-1; j <= x+1; j++)
                {
                    if (i < 0 || j < 0 || i >= height || j >= width || (j == x && i == y)) 
                    continue;
                    if (field[i, j]) 
                        count++;
                }
            }
            return count;
        }

        public bool NextGeneration()
        {
            bool changed = false;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int neighbors = countNeighbors(y, x);
                    if (field[y, x] && (neighbors < 2 || neighbors > 3))
                    {
                        newField[y, x] = false;
                        changed = true;
                    }
                    else if (!field[y, x] && neighbors == 3)
                    {
                        newField[y, x] = true;
                        changed = true;
                    }
                    else
                    {
                        newField[y, x] = field[y, x];
                    }
                }
            }
            if (!changed)
            {
                Console.WriteLine("Game over");
                return false;
            }
            if (ArrayEquals(field, newField))
            {
                Console.WriteLine("Game over");
                return false;
            }
            field = (bool[,])newField.Clone();
            PrintField();
            return true;
        }

        private bool ArrayEquals(bool[,] a1, bool[,] a2)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (a1[i, j] != a2[i, j]) return false;
                }
            }
            return true;
        }

        private void PrintField()
        {
            Console.WriteLine();
            
            for (int y = height; y > 0; y--)
            {
                Console.Write("{0}\t", y);
                for (int x = 0; x < width; x++)
                    Console.Write(field[y-1, x] ? "+\t" : "-\t");
                Console.WriteLine();
            }
            for (int x = 0; x <= width; x++)
                Console.Write("{0}\t", x);
            Console.WriteLine();
        }
    }

}
