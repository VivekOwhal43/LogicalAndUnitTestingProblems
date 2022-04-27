using System;
using System.Diagnostics;

namespace Logical_Program_part_1
{
    internal class StopWatchSimulator
    {
        public void StopWatch()
        {
            Console.WriteLine("Welcome to Stop Watch Simulator");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Start");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
        }
    }
}