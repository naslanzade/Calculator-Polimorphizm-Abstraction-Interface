using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Calculation : ICalculation
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("add operation");
            string operation = Console.ReadLine();


            switch (operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }
}
