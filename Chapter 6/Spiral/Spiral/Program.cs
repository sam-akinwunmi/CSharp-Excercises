using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int matrixLength = int.Parse(Console.ReadLine());

            int[,] spiralMatrix = new int[matrixLength, matrixLength];

            FillMatrix(spiralMatrix, matrixLength);

            PrintMatrix(spiralMatrix, matrixLength);
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            int positionX = 0;
            int positionY = 0;

            int direction = 0;
            int stepsCount = n-1;
            int stepPosition = 0;
            int stepChange = 3;

            for (int i = 1; i <= n * n; i++)
            {
                matrix[positionY, positionX] = i;
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount--;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }

                switch (direction)
                {
                    case 0:
                        positionX++;
                        break;
                    case 1:
                        positionY++;
                        break;
                    case 2:
                        positionX--;
                        break;
                    case 3:
                        positionY--;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
