using System;

namespace HW_04_Task01
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
            bool chek = Int32.TryParse(Console.ReadLine(),out int var1);
             while(chek == false)
                {
                    Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                    chek = Int32.TryParse(Console.ReadLine(), out var1);
                }
            Console.WriteLine("Please input second number");
            chek = Int32.TryParse(Console.ReadLine(), out int var2);
                while (chek == false)
                {
                    Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                    chek = Int32.TryParse(Console.ReadLine(), out var2);
                }
            int result = var1 + var2;
            Console.WriteLine($"{var1}+{var2}={result}");
        }
    }
}