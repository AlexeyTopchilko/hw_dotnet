using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year of your birth");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of month of your birth");
            int monthOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter present year");
            int presentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of present month");
            int presentMonth = Convert.ToInt32(Console.ReadLine());

            int age = presentYear - yearOfBirth;
            
            if( presentMonth < monthOfBirth)
            {
                age-= 1;
            }
            Console.WriteLine($"Your age is {age}");
        }
    }
}