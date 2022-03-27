// See https://aka.ms/new-console-template for more information
using System;

namespace LogicAndUnit // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonecci fibonecci = new Fibonecci();
            fibonecci.calculateFibinecci();
        }
    }
}