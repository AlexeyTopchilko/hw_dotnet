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
            while (chek == false || size <= 0 )
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
            Console.WriteLine("\nRandom massiv is :");
            for(int i = 0;i < size;i++)
            {
                randomMass[i] = num.Next();
                Console.Write(randomMass[i]+" ");
            }
            return randomMass;
        }

        public static int[] UsersMass(int size)
        {
            int[] usersMass = new int[size];
            for(int i = 0;i < size;i++)
            {
                Console.WriteLine("\nPlease input a number :");
                bool chek = Int32.TryParse(Console.ReadLine(), out usersMass[i]);
                while (chek == false)
                {
                    Console.WriteLine("Wrong number\nPlease input a number :");
                    chek = Int32.TryParse(Console.ReadLine(), out usersMass[i]);
                }
            }
            Console.WriteLine("You'r massiv is :");
            foreach (int item in usersMass)
            {
                Console.Write(item+" ");
            }
            return usersMass;
        }

        public static int[] SummMass(int size, int[] randomMass, int[] usersMass)
        {
            int[] summMass = new int[size];
            Console.WriteLine("\nThe result of summing two massiv's is :");
            for(int i = 0;i < size;i++)
            {
                summMass[i] = randomMass[i] + usersMass[i];
                Console.Write(summMass[i]+" ");
            }
            return summMass;
        }
    }
}