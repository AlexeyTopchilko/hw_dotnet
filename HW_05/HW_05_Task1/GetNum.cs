using System;


namespace HW_05_Task1
{
    class GetNum
    {
        public static int GetNumber()
        {
            Console.WriteLine("Please input a nuber more than 0");
            bool chek = Int32.TryParse(Console.ReadLine(), out int number);
            while (chek == false || number <= 0)
            {
                Console.WriteLine("Please input a number more then 0");
                chek = Int32.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}