using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = CreateMass.GetSize();

            int[] randomMass = CreateMass.RandomMass(size);
            Console.WriteLine("Random massiv is :");
            foreach (int item in randomMass)
             Console.Write(item + " ");

            int[] usersMass = CreateMass.UsersMass(size);
            Console.WriteLine("You'r massiv is :");
            foreach (int item in usersMass)
                Console.Write(item + " ");

            int[] summMass = CreateMass.SummMass(randomMass, usersMass);
            if (summMass != null)
            {
                Console.WriteLine("\nThe result of summing massiv's is : ");
                foreach (int item in summMass)
                    Console.Write(item + " ");
            }
            else
                Console.WriteLine("\nSize of massiv's must be the same!");
        }
    }
}