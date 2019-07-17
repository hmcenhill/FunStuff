using System;
using System.Collections.Generic;
using System.Text;

namespace FunStuff
{
    public class App
    {
        public void Run()
        {
            var frqcnt = new ProblemSolvingPatterns.FrequencyCounter();
            Console.WriteLine(frqcnt.Anagram("hloworldel", "worldhello"));

            var slide = new ProblemSolvingPatterns.SlidingWindow();
            Console.WriteLine(slide.MaxSubarraySum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5));
            Console.WriteLine(slide.MaxSubarraySum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1));
            Console.WriteLine(slide.MaxSubarraySum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 11));
            Console.WriteLine(slide.MaxSubarraySum(new int[] { }, 5));
        }
    }
}
