using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    internal class CustomMath
    {
        public  int SumOfOddInArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public string OddOrEvenNUmber(int n)
        {
            if (n % 2 == 0)
            {
                return "cut";
            }
            else
            {
                return "tek";
            }
        }
        public int SquareSumEvenNumber(int[]arr1)
        {
            int sum = 0;
            int square;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    sum += arr1[i];
                }
            }
            square = sum * sum;
            return square;
        }
        public int ResultOfNumber(int n)
        {
            int result = 1; 
            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
