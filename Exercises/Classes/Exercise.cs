using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercises.Classes
{
    public class Exercise
    {
        public static void Start() 
        {
            var first = new Stopwatch();
            first.Start();
            Thread.Sleep(100);
            first.Stop();
            Console.WriteLine($"First stopwatch is {first.Duration}");

            var second = new Stopwatch();
            second.Start();
            Thread.Sleep(5000);
            second.Stop();
            Console.WriteLine($"Second stopwatch is {second.Duration}");
        }
    }
}
