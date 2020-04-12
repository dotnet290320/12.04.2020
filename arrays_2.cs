using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace today1204
{
    class Program
    {
       

        static int InputNumberFromUserInRange(string message, int min, int max)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
            }
            while (int.TryParse(Console.ReadLine(), out number) == false || number < min || number > max);

            return number;
        }

        private static void GenerateRandomMatrix(int[,] matrix)
        {
            Random random_generator = new Random(); // chinese --

            for (int i = 0; i < matrix.GetLength(0); i++) // rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // columns
                {
                    matrix[i, j] = random_generator.Next(1, 10);
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            // print the matrix
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /*
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[4];
            jagged[2] = new int[3];

            jagged[1][2] = 90;
            */

            // 1 is row
            // 2 is column
            int rows = 7;
            int col = 3;
            int[,] matrix = new int[rows, col];
            //int[,,] matrix2 = new int[10, 10, 20];


            // generate random numbers for matrix
            GenerateRandomMatrix(matrix);

            // print the matrix
            PrintMatrix(matrix);

        }


    }
}
