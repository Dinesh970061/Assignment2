using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Loop
{
    class Loop
    {
       public static void Fib(int number)
        {
            int firstNum = 0, SecondNum = 1, Result;
            for (int iteration = 1; iteration < number; iteration++)
            {
                Result = firstNum + SecondNum;
                firstNum = SecondNum;
                SecondNum = Result;
                Console.Write(Result + " ");
            }
        }
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the length of the sequence");
            number = int.Parse(Console.ReadLine());
            Console.Write("0 1 ");
            Fib(number);
            Console.ReadKey();
        }
    }
}
