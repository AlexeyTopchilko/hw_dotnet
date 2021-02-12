using System;

namespace HW_04_Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int unicodeDec = 90; unicodeDec > 64; unicodeDec--)
            {
                char letter = Convert.ToChar(unicodeDec);
                Console.WriteLine(letter);
            }
        }
    }
}