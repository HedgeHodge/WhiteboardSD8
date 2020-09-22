using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    public class Collections
    {
        static Random rand = new Random();

        public static int[] TestScores(int numOfScores)
        {
            int[] scores = new int[numOfScores];
            for (int i = 0; i < numOfScores; i++)
            {
                scores[i] = rand.Next(101);
            }

            return scores;
        }

        public static double AverageScore(int[] scores)
        {
            double sum = scores.Sum();
            return Math.Floor(sum / scores.Length); 
        }

        public static int GetMaxVal(int[] arrInput)
        {
            int max = arrInput[0];
            for (int i = 0; i < arrInput.Length; i++)
            {
                if(arrInput[i] > max)
                {
                    max = arrInput[i];
                }
            }
            return max;
        }

        public static int[] sortArray(int[] arrInput)
        {
            for (int i = 0; i < arrInput.Length - 1; i++)
            {
                for (int j = 0; j < arrInput.Length - 1; j++)
                {
                    if(arrInput[j] > arrInput[j + 1])
                    {
                        int temp = arrInput[j];
                        arrInput[j] = arrInput[j + 1];
                        arrInput[j+1] = temp;
                    }
                }
            }
            return arrInput;
        }
    }
}
