using System;

namespace Oplab_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort
            int[] array = {9, 5, 2, 6, 10, 8, 7, 1, 4, 3};

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
