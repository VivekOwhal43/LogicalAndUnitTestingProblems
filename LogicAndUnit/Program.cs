// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using Logical_Program_part_1;

namespace LogicAndUnit // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Choice: ");
            Console.WriteLine("\n1.Fibonecci Series \n2.Stopwatch Simulator \n3. Reverse Number"); 
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Fibonecci fibonecci = new Fibonecci();
                    fibonecci.calculateFibinecci();
                    break;
                case 2:
                    StopWatchSimulator stopWatchSimulator = new StopWatchSimulator();
                    stopWatchSimulator.StopWatch();
                    break;
                    case 3:
                    Reversenumber reversenumber = new Reversenumber();
                    reversenumber.ReverseEnteredNumber();
                    break;
            }
        }
    }
}