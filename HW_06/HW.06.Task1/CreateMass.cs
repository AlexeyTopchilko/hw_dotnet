using System;
using System.Collections.Generic;
using System.Text;

namespace HW._06.Task1
{
    class CreateMass
    {
        public static int GetSize()
        {
         Console.WriteLine("Please input size of array");
            bool chek = Int32.TryParse(Console.ReadLine(), out int size);
            while (!chek || size <= 0 )
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
            for(int i = 0;i < size;i++)
                randomMass[i] = num.Next();

            return randomMass;
        }

        public static int[] UsersMass(int size)
        {
            int[] usersMass = new int[size];
            for(int i = 0;i < size;i++)
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

        public static int[] SummMass(int[] randomMass, int[] usersMass)
        {
            int[] summMass;
            if (randomMass.Length == usersMass.Length)
            {
                int size = randomMass.Length;
                summMass = new int[size];
                for (int i = 0; i < size; i++)
                    summMass[i] = randomMass[i] + usersMass[i];
                return summMass;
            }
            else 
                return null;
        }
    }
}