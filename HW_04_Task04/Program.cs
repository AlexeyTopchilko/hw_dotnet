using System;

namespace HW_04_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number");
            bool chekVar1 = Int32.TryParse(Console.ReadLine(), out int var1);
            while (chekVar1 == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chekVar1 = Int32.TryParse(Console.ReadLine(), out var1);
            }

            Console.WriteLine("Please input second number");
            bool chekVar2 = Int32.TryParse(Console.ReadLine(), out int var2);
            while (chekVar2 == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chekVar2 = Int32.TryParse(Console.ReadLine(), out var2);
            }

            Console.WriteLine("Please input + or -");
            string @operator = Console.ReadLine();
            while (@operator != "-" && @operator != "+")
            {
                Console.WriteLine("Wrong operator\nPlease input + or -");
                @operator = Console.ReadLine();
            }

            if (@operator == "+")
            {
                Plus(var1, var2);
            }
            else
            {
                Minus(var1, var2);
            }
        }
        static void Plus(int var1, int var2)
        {
            Console.WriteLine($"Please input a result of {var1}+{var2}=");
            bool chekResult = Int32.TryParse(Console.ReadLine(), out int result);
            while (chekResult == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chekResult = Int32.TryParse(Console.ReadLine(), out result);
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
        static void Minus(int var1, int var2)
        {
            Console.WriteLine($"Please input a result of {var1}-{var2}=");
            bool chekResult = Int32.TryParse(Console.ReadLine(), out int result);
            while (chekResult == false)
            {
                Console.WriteLine("Thats not a number\nPlease input a NUMBER");
                chekResult = Int32.TryParse(Console.ReadLine(), out result);
            }
            if (result == var1 - var2)
            {
                Console.WriteLine("You're right!");
            }
            else
            {
                if (result < var1 - var2)
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