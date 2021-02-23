using System;

namespace HW._07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] @string = SplitString(GetString());
            foreach (var item in @string)
                Console.WriteLine(item);
            Console.WriteLine();
            string[] changedString = ChangeString(@string);
            foreach (var item in changedString)
                Console.WriteLine(item);
        }

        static string GetString()
        {
            Console.WriteLine("Please input a poem\nLines split with \";\" ");
            string @string = Console.ReadLine().ToUpper();
            return @string;
        }

        static string[] SplitString(string @string)
        {
            string[] splitString = @string.Split(';');
            return splitString;
        }
        
        static string[] ChangeString(string[] splitString)
        {
            Console.WriteLine("Please input a letter that you want to change");
            string letterToChange = Console.ReadLine().ToUpper();
            Console.WriteLine("Please input a letter to insert");
            string letterToInsert = Console.ReadLine().ToUpper();
            int size = splitString.Length;
            string[] changedString = new string[size];
            for (int i = 0; i < size; i++)
            {
                changedString[i] = splitString[i].Replace(letterToChange, letterToInsert);
            }
            return changedString;
        }
    }
}