using System;
using System.Collections.Generic;
using System.Text;

namespace HW_05_Task2
{
    class GetNum
    {
        public static int GetNumber()
        {
            Console.WriteLine("Please input a nuber beteen 0 and 100");
            bool chek = Int32.TryParse(Console.ReadLine(), out int number);
            while (chek == false || number <= 0 || number >100)
            {
                Console.WriteLine("Please input a number between 0 and 100");
                chek = Int32.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}