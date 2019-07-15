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
            Console.WriteLine(frqcnt.Same("hloworldel", "worldhello"));


        }
    }
}
