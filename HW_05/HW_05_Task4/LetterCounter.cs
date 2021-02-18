using System;
using System.Collections.Generic;
using System.Text;

namespace HW_05_Task4
{
    class LetterCounter
    {
        public static void ACounter()
        {
            int count = 0;
            Console.WriteLine("Please input a word");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length ; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' || word[i] == 'А' || word[i] == 'а')   // Chek on cyrillic and latin,it's work
                    ++count;
            }
            Console.WriteLine("Number of 'A' is " + count);
        }
    }
}