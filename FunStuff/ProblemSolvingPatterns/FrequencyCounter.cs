using System;
using System.Collections.Generic;
using System.Text;

namespace FunStuff.ProblemSolvingPatterns
{
    public class FrequencyCounter
    {
        public bool Anagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            foreach (var c in s1)
            {
                if (!s2.Contains(c))
                {
                    return false;
                }
                var index = s2.IndexOf(c);
                s2 = s2.Remove(index, 1);
            }
            return true;
        }
        public bool AreThereDuplicates(string s)
        {
            var checker = "";
            foreach (var c in s)
            {
                if (checker.Contains(c)) return false;
                checker += c;
            }
            return true;
        }
    }
}
