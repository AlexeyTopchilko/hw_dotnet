using System;

namespace HW_04_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Plus();
        }
        static void Plus()
        {
            Console.WriteLine("Please input first number");
            bool chek1 = Int32.TryParse(Console.ReadLine(), out int var1);
            while (chek1 == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chek1 = Int32.TryParse(Console.ReadLine(), out var1);
            }
            Console.WriteLine("Please input second number");
            bool chek2 = Int32.TryParse(Console.ReadLine(), out int var2);
            while (chek2 == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chek2 = Int32.TryParse(Console.ReadLine(), out var2);
            }

            Console.WriteLine($"Please input a result of {var1}+{var2}=");
            bool chek3 = Int32.TryParse(Console.ReadLine(), out int result);
            while (chek3 == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chek3 = Int32.TryParse(Console.ReadLine(), out result);
            }
                if(result == var1 + var2)
                {
                    Console.WriteLine("You're right!");
                }
                else
                {
                    Console.WriteLine("You're wrong!");
                }
        }
    }
}