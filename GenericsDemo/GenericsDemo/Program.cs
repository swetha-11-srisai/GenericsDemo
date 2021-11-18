using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 3, 4, 5, 2 };
            double[] doubleArray = { 2.1, 3.3, 4.2, 5.1, 2.4 };
            char[] charArray = { 'S','W','E','T','H' };
            Program.ToPrint<int>(intArray);
            Program.ToPrint<double>(doubleArray);
            Program.ToPrint<char>(charArray);
        }
        public static  void ToPrint<T>(T[] inputArray)
        {
            foreach(var elements in inputArray)
            {
                Console.WriteLine(elements);
            }
        }
       
    }
}
