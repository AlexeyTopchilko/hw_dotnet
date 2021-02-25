using System;

namespace HW._07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = GetString();
            Console.WriteLine(@string);

            string stringWithoutWord = DeleteTheLongestWord(@string);
            Console.WriteLine("You'r string without the longest word is:");
            Console.WriteLine(stringWithoutWord);

            string stringToMoveWords = SwapTheWords(@string);
            Console.WriteLine("Result of swaping the longest and the shortest word's");
            Console.WriteLine(stringToMoveWords);

            SymbolsCouter(@string);

            string[] sortArray = LengthSort(@string);
            Console.WriteLine("Your sorted string is :");
            foreach (string item in sortArray)
                Console.Write(item + " ");
        }

        static string GetString()
        {
            Console.WriteLine("Please input a word's ");
            string @string = Console.ReadLine();
            return @string;
        }

        static string DeleteTheLongestWord(string @string)
        {
            string[] arrayWithoutLongestWord = @string.Split(' ');
            int index = 0;
            int size = arrayWithoutLongestWord.Length;
            for (int i = 0; i < size; i++)
                index = arrayWithoutLongestWord[i].Length > arrayWithoutLongestWord[index].Length ? i : index;
            arrayWithoutLongestWord[index] = arrayWithoutLongestWord[index].Remove(0);
            string stringWithoutLongestWord = string.Empty;
            foreach (string item in arrayWithoutLongestWord)
            {
                if (item.Equals(string.Empty))
                    continue;
                stringWithoutLongestWord += item + " ";
            }
            return stringWithoutLongestWord;
        }

        static string SwapTheWords(string @string)
        {
            string[] arrayToSwapWords = @string.Split(' ');
            int size = arrayToSwapWords.Length;

            int longestInd = 0;
            for (int i = 0; i < size; i++)
                longestInd = arrayToSwapWords[i].Length > arrayToSwapWords[longestInd].Length ? i : longestInd;

            int shortestInd = 0;
            for (int i = 0; i < size; i++)
                shortestInd = arrayToSwapWords[i].Length < arrayToSwapWords[shortestInd].Length ? i : shortestInd;

            string buffer = arrayToSwapWords[shortestInd];
            arrayToSwapWords[shortestInd] = arrayToSwapWords[longestInd];
            arrayToSwapWords[longestInd] = buffer;

            string stringToSwapWords = string.Empty;
            foreach (string item in arrayToSwapWords)
                stringToSwapWords += item + " ";

            return stringToSwapWords;
        }

        static void SymbolsCouter(string @string)
        {
            int punctuationCounter = 0;
            int letterCounter = 0;
            int numberCounter = 0;
            int anotherCounter = 0;
            foreach (char item in @string)
            {
                if (Char.IsPunctuation(item))
                    ++punctuationCounter;
                else if (Char.IsLetter(item))
                    ++letterCounter;
                else if (Char.IsNumber(item))
                    ++numberCounter;
                else
                    ++anotherCounter;
            }
            Console.WriteLine($"There is {punctuationCounter} punktuation marks, {letterCounter} letter's");
            Console.WriteLine($"{numberCounter} number's and {anotherCounter} another symbol's");
        }

        static string[] LengthSort(string @string)
        {
            string[] sortArray = @string.Split(' ');
            int size = sortArray.Length;
            for (int i = 0; i < size; i++)
            {
                int index = i;
                string buffer = sortArray[i];
                for (int j = i; j < size; j++)
                    index = sortArray[j].Length > sortArray[index].Length ? j : index;
                sortArray[i] = sortArray[index];
                sortArray[index] = buffer;
            }
            return sortArray;
        }
    }
}