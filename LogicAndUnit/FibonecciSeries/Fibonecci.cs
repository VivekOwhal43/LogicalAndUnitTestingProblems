using System.Globalization;

namespace LogicAndUnit
{
    public class Fibonecci
    {
        int acceptNum, fib, num1=0, num2=1;
        public void calculateFibinecci()
        {
            Console.WriteLine("Enter a Number: ");
            acceptNum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{num1} {num2}");
            for (int i =2; i<= acceptNum; i++)
            {
                fib=num1 +num2;
                Console.Write($" {fib}");
                num1= num2;
                num2 = fib;
            }
            Console.WriteLine("");
        }
    }
}