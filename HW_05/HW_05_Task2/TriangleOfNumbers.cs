using System;


namespace HW_05_Task2
{
    class TriangleOfNumbers
    {
        public static void TriangleOfNumber(int number)
        {
                for (int outputNum = 1; outputNum <= number; outputNum++)
                {

                    for (int length = number + 1 - outputNum; length > 0; length--)
                    {
                        Console.Write(outputNum % 10);
                        if (length > 1)
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                    for (int numOfSpaces = 1; numOfSpaces <= outputNum; numOfSpaces++)
                        Console.Write(" ");
                }
        }
    }
}