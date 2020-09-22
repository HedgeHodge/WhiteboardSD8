using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Collections.TestScores(100);
            Console.WriteLine($"The average is: {Collections.AverageScore(array)}");
            Console.WriteLine($"The max value is: {Collections.GetMaxVal(array)}");
            int[] sortedArray = Collections.sortArray(array);
            foreach(int i in sortedArray)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
