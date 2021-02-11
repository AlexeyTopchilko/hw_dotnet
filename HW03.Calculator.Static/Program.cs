using System;

namespace HW03.Calculator.Static
{
    class Program
    {
        static void Main()
        {
            Calculator.Plus();
            Calculator.Minus();
            Calculator.Multiplication();
            Calculator.Divide();
            Calculator.Reminder();
            Calculator.AreaOfCircle();
        }
    }
     class Calculator
    {
        public static void Plus()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 + var2;
            Console.WriteLine($"{var1}+{var2}={result}");
        }
        public static void Minus()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 - var2;
            Console.WriteLine($"{var1}-{var2}={result}");
        }
        public static void Multiplication()
        {
            Console.WriteLine("Please enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int result = var1 * var2;
            Console.WriteLine($"{var1}*{var2}={result}");
        }
        public static void Divide()
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
            int result = var1 / var2;
            Console.WriteLine($"{var1}/{var2}={result}");
        }
        public static void Reminder()
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
        }
        public static void AreaOfCircle()
        {
            Console.WriteLine("Please enter radius");
            int radius = Int32.Parse(Console.ReadLine());
            double result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of circle is {result}");
        }
    }
}