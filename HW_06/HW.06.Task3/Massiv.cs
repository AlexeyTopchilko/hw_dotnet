using System;
using System.Collections.Generic;
using System.Text;

namespace HW._06.Task3
{
    class Massiv
    {
        public static int GetSize()
        {
            Console.WriteLine("Please input size of array");
            bool chek = Int32.TryParse(Console.ReadLine(), out int size);
            while (!chek || size <= 0)
            {
                Console.WriteLine("Please input correct size of array");
                chek = Int32.TryParse(Console.ReadLine(), out size);
            }
            return size;
        }

        public static int[] RandomMass(int size)
        {
            int[] randomMass = new int[size];
            Random num = new Random();
            for (int i = 0; i < size; i++)
                randomMass[i] = num.Next();

            return randomMass;
        }

        public static int[] Reverse(int[] mass)
        {
            int size = mass.Length;
            for(int i =0;i <= (size-1)/2;i++)
            {
                int buffer = mass[size- 1 - i];
                mass[size - 1 - i] = mass[i];
                mass[i] = buffer;
            }
            return mass;
        }
    }
}