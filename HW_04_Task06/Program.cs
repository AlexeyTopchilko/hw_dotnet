using System;

namespace HW_04_Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a direction");
            string direction = Console.ReadLine();
            switch(direction)
            {
                case "w":
                    Console.WriteLine("Move it up!");
                    break;
                case "a":
                    Console.WriteLine("Move it left!");
                    break;
                case "s":
                    Console.WriteLine("Move it down!");
                    break;
                case "d":
                    Console.WriteLine("Move it right!");
                    break;
                case "" :
                    Console.WriteLine("Don't move it");
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
}
