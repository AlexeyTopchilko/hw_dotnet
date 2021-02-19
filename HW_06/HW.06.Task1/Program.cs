using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = CreateMass.GetSize();

            int[] randomMass = CreateMass.RandomMass(size);
            int[] usersMass = CreateMass.UsersMass(size);
            CreateMass.SummMass(size, randomMass, usersMass);
        }
    }
}