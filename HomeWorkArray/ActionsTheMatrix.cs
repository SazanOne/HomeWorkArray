using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArray
{
    public class ActionsTheMatrix
    {
        public static void OptionInfo()
        {
            Console.WriteLine("""
                              Список доступных операций с двухмерным массивом:
                                1 - Найти количество положительных чисел в матрице
                                2 - Найти количество отрицательных чисел в матрице
                                3 - Сортировка элементов матрицы построчно по возврастанию
                                4 - Сортировка элементов матрицы построчно по убыванию
                                5 - Инверсия элементов матрицы построчно
                              """);
        }
        public static void SelectOperations(int action, int[,]array)
        {
            switch (action)
            {
                case 1:
                    PositiveNumbers(array);
                    break;
                case 2:
                    NegativeNumbers(array);
                    break;
                case 3:
                    BubbleSortIncreasing(array);
                    break;
                case 4:
                    BubbleSortDecreasing(array);
                    break;
                case 5:
                    Invert(array);
                    break;
                default:
                    Console.WriteLine("Невверный ввод");
                    break;
            }
        }
        private static void PositiveNumbers(int[,] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item > 0)
                    counter++;
            }
            Console.WriteLine($"Ваш результат {counter}");
        }

        private static void NegativeNumbers(int[,] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item < 0)
                    counter++;
            }
            Console.WriteLine($"Ваш результат {counter}");
        }

        private static void BubbleSortIncreasing(int[,] array)
        {
            Console.WriteLine("Выберете строку для сортировки");
            int line = Matrix.CheckForNumber()  - 1;
            int counter = 0;
            while (counter < array.GetLength(1))
            {
                for (int i = 0; i < array.GetLength(1) - 1 - counter; i++)
                {
                    if (array[line, i] > array[line, i + 1])
                    {
                        int itemForReplace = array[line, i + 1];
                        array[line, i + 1] = array[line, i];
                        array[line, i] = itemForReplace;
                    }
                }
                counter++;
            }
            Matrix.PrintMatrix(array);
        }

        private static void BubbleSortDecreasing(int[,] array)
        {
            Console.WriteLine("Выберете строку для сортировки");
            int line = Matrix.CheckForNumber() - 1;
            int counter = 0;
            while (counter < array.GetLength(1))
            {
                for (int i = 0; i < array.GetLength(1) - 1 - counter; i++)
                {
                    if (array[line, i] < array[line, i + 1])
                    {
                        int itemForReplace = array[line, i + 1];
                        array[line, i + 1] = array[line, i];
                        array[line, i] = itemForReplace;
                    }
                }
                counter++;
            }
            Matrix.PrintMatrix(array);
        }

        private static void Invert(int[,] array)
        {
            Console.WriteLine("Выберете строку для инверсии");
            int line = Matrix.CheckForNumber() - 1;
            int[] lineArray = new int[array.GetLength(1)];
            int j = array.GetLength(1) - 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                lineArray[j] = array[line, i];
                j--;
            }

            int k = 0;
            foreach (int item in lineArray)
            {
                array[line, k] = item;
                k++;
            }
            Matrix.PrintMatrix(array);
        }
    }
}
