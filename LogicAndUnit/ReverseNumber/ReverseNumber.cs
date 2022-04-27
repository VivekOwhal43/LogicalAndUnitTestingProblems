using System;

namespace LogicAndUnit
{
    internal class Reversenumber
    {
        public void ReverseEnteredNumber()
        {
            Console.WriteLine("Welcome to Reverse Number");
            Console.WriteLine("Please Enter a Number To Create Reverese Number: ");
            int num = int.Parse(Console.ReadLine());
            int temp, rem, rev = 0;     //veriables for storing temporary values
            temp = num;
            while (num > 0)     //until number is greater than 0 while block will get executed
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("Reverse of the number " + temp + " is: " + rev);
            Console.ReadLine();
        }


    }
}
