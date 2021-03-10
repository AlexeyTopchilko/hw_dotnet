using System;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = CreateMass.UsersMass(CreateMass.GetSize());
            Console.WriteLine("You'r massiv is :");
            foreach (int item in mass)
                Console.Write(item + " ");

            CreateMass.AddToMass(mass);
            Console.WriteLine("You'r new massiv is :");
            foreach (int item in mass)
                Console.Write(item + " ");
        }
    }
}