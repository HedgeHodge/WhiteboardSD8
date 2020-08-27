using System;
using System.Linq;

namespace NumOfDistinct
{
    public class DistinctNumbers
    {
        public static int CountDistinct ( int[] intArr )
        {
            int[] newArr = intArr;
            int count = 0;

            foreach(int num in intArr)
            {
                if(newArr.Contains(num))
                {
                    continue;
                }
                else
                {
                    count++;
                }
                Console.WriteLine(count);
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountDistinct(new int[] { 9, 2, 1, 0, 1 }));
        }
    }
}
