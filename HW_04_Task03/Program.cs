using System;

namespace HW_04_Task03
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
            bool chek = Int32.TryParse(Console.ReadLine(), out int var1);
            while (chek == false)
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
            Console.WriteLine($"Please input a result of {var1}+{var2}=");
            chek = Int32.TryParse(Console.ReadLine(), out int result);
            while (chek == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chek = Int32.TryParse(Console.ReadLine(), out result);
            }
            if (result == var1 + var2)
            {
                Console.WriteLine("You're right!");
            }
            else
            {
                if (result < var1 + var2)
                {
                    Console.WriteLine("You're wrong!\nShould be more!");
                }
                else
                {
                    Console.WriteLine("You're wrong!\nShould be less!");
                }
            }
        }
    }
}