using System;

namespace PrimeNumber
{
    public class Prime
    {
        public static bool IsPrime(int possPrime)
        {
            for(int i = 2; i < possPrime; i++)
            {
                if(possPrime % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
