using System;
using System.Collections.Generic;
using System.Text;

namespace HW._06.Task2
{
    class CreateMass
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

        public static int[] UsersMass(int size)
        {
            int[] usersMass = new int[size];
            for (int i = 0; i < size-1; i++)
            {
                Console.WriteLine("\nPlease input a number :");
                bool chek = Int32.TryParse(Console.ReadLine(), out usersMass[i]);
                while (!chek)
                {
                    Console.WriteLine("Wrong number\nPlease input a number :");
                    chek = Int32.TryParse(Console.ReadLine(), out usersMass[i]);
                }
            }
            return usersMass;
        }

        public static int[] AddToMass(int[] mass)
        {
            Console.WriteLine("\nPlease input a number to add");
            bool chek = Int32.TryParse(Console.ReadLine(), out int number);
            while (!chek)
            {
                Console.WriteLine("Please input correct number");
                chek = Int32.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("Please input a position from 1 to "+mass.Length);
            chek = Int32.TryParse(Console.ReadLine(), out int position);
            while (!chek || position < 1 || position > mass.Length)
            {
                Console.WriteLine("Please input a position from 1 to " + mass.Length);
                chek = Int32.TryParse(Console.ReadLine(), out position);
            }
            for(int i = mass.Length-1;i > position-1;i--)
            {
                mass[i] = mass[i - 1];
            }
            mass[position-1] = number;
            return mass;
        }
    }
}