using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArray
{
    public class Matrix
    {   
        public static void GettingStartedWithTheMatrix()
        {
            Console.WriteLine("Введите размерность матрицы ");
            Console.WriteLine("Введите количество строк ");
            int rows = Matrix.CheckForNumber();

            Console.WriteLine("Введите количество столбцов");
            int colons = Matrix.CheckForNumber();


            int[,] array = Matrix.FillMatrix(rows, colons);
            Matrix.PrintMatrix(array);

            while (true)
            {
                ActionsTheMatrix.OptionInfo();
                int action = Matrix.CheckForNumber();
                ActionsTheMatrix.SelectOperations(action, array);

                Console.WriteLine("Для выхода нажмите <Escape>");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }
        }
       
        public static int CheckForNumber()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Вы ввели не число!");
                Console.WriteLine("Введите заново: ");
            }
            return result;
        }

        public static void PrintMatrix(int[,] array)
        {
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static int[,] FillMatrix(int rows, int colons)
        {
            Console.WriteLine("\nЗаполнение матрицы\n");
            int[,] array = new int[rows, colons];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colons; j++)
                {
                    Console.Write("Введите числа матрицы: ");
                    array[i, j] = Matrix.CheckForNumber();
                }
            }
            return array;
        }
    }
}
