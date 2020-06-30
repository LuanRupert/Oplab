
using System.IO;
using System;

namespace Oplab_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("C:\\Users\\LuanRupert\\source\\repos\\Oplab Challenge\\GameOfStone.txt");

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string result = gameOfStones(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }

        static string gameOfStones(int n)
        {
            if (n % 7 == 0 || n % 7 == 1)
            {
                return "Second";
            }
            else
            {
                return "First";
            }
        }
    }
}
