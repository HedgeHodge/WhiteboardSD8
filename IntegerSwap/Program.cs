using System;

namespace IntegerSwap
{
    class Program
    {
        static void IntSwap(int X, int Y)
        {
            Console.WriteLine($"{X}<==>{Y}");
            X = X + Y;
            Y = X - Y;
            X = X - Y;
            Console.WriteLine($"{X}<==>{Y}");
        }
        static void Main(string[] args)
        {
            IntSwap(5, 26);
        }
    }
}
