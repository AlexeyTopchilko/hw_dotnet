using System;

namespace HW_04_Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int unicodeDec = 90; unicodeDec > 64; unicodeDec--)   // Z=90(dec) A=65(dec)
            {
                char letter = Convert.ToChar(unicodeDec);
                Console.WriteLine(letter);
            }
        }
    }
}