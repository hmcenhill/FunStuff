using System;
using System.Collections.Generic;
using System.Text;

namespace FunStuff.ProblemSolvingPatterns
{
    public class SlidingWindow
    {
        // Write a function which accepts an array of integers and a number n. The function should calculate the maximum sum of n consecutive array elements.
        public int? MaxSubarraySum(int[] arr, int elements)
        {
            if (elements > arr.Length) return null;
            var currentMaxSum = 0;
            for (var i = 0; i <= arr.Length - elements; i++)
            {
                var sum = 0;
                for (var j = i; j < i + elements; j++)
                {
                    sum += arr[j];
                }
                if (sum > currentMaxSum) currentMaxSum = sum;
            }
            return currentMaxSum;
        }
    }
}
