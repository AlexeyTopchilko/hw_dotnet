using System;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = Massiv.RandomMass(Massiv.GetSize());
            foreach (int item in mass)
                Console.Write(item+" ");
            Console.WriteLine();
            Massiv.Reverse(mass);
            foreach (int item in mass )
            {
                Console.Write(item+" ");
            }
        }
    }
}