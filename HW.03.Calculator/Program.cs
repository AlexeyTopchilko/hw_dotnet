using System;

namespace HW._03.Calculator
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            calc.Plus();
            calc.Minus();
            calc.Multiplication();
            calc.Divide();
            calc.Remainder();
            calc.AreaOfCircle();
        }
    }
    class Calculator
    {
        public int Plus()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 + var2;
            Console.WriteLine($"{var1}+{var2}={result}");
            return result;
        }
        public int Minus()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 - var2;
            Console.WriteLine($"{var1}-{var2}={result}");
            return result;
        }
        public int Multiplication()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 * var2;
            Console.WriteLine($"{var1}*{var2}={result}");
            return result;
        }
        public int Divide()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Int32.Parse(Console.ReadLine());
            if(var2 ==0)
            {
                while(var2 ==0)
                {
                    Console.WriteLine("Cannot be divided by zero\nPlease enter another number");
                    var2 = Int32.Parse(Console.ReadLine());
                }
            }
            int result = var1 / var2;
            Console.WriteLine($"{var1}/{var2}={result}");
            return result;
        }
        public int Remainder()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Int32.Parse(Console.ReadLine());
            if (var2 == 0)
            {
                while (var2 == 0)
                {
                    Console.WriteLine("Cannot be divided by zero\nPlease enter another number");
                    var2 = Int32.Parse(Console.ReadLine());
                }
            }
            int result = var1 % var2;
            Console.WriteLine($"The remainder of {var1}/{var2} is {result}");
            return result;
        }
        public double AreaOfCircle()
        {
            Console.WriteLine("Please enter radius");
            int radius = Int32.Parse(Console.ReadLine());
            double result = Math.PI * Math.Pow(radius,2);
            Console.WriteLine($"Area of circle is {result}");
            return result;
        }
    }
}