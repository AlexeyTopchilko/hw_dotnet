using System;

namespace HW._07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = GetString();
            GetVariables(@string, out char @operator, out int var1, out int var2);
            int result = MathOperation(@operator, var1, var2);
        }

        static void GetVariables(string @string, out char @operator, out int var1, out int var2)
        {
            string[] variables = @string.Split('*', '/', '+', '-');
            @operator = @string[variables[0].Length];
            string stringVar1 = string.Empty;
            string stringVar2 = string.Empty;
            foreach (char item in variables[0])
            {
                if (Char.IsDigit(item))
                    stringVar1 += item;
            }
            foreach (char item in variables[1])
            {
                if (Char.IsDigit(item))
                    stringVar2 += item;
            }
            var1 = Int32.Parse(stringVar1);
            var2 = Int32.Parse(stringVar2);
        }

        static string GetString()
        {
            Console.WriteLine("Please input a string ");
            string @string = Console.ReadLine();
            return @string;
        }

        static int MathOperation(char @operator, int var1, int var2)
        {
            int result = 0;
            switch (@operator)
            {
                case '+':
                    result = var1 + var2;
                    Console.WriteLine($"{var1}{@operator}{var2}={result}");
                    break;
                case '-':
                    result = var1 - var2;
                    Console.WriteLine($"{var1}{@operator}{var2}={result}");
                    break;
                case '*':
                    result = var1 * var2;
                    Console.WriteLine($"{var1}{@operator}{var2}={result}");
                    break;
                case '/':
                    if (var2 != 0)
                    {
                        result = var1 / var2;
                        Console.WriteLine($"{var1}{@operator}{var2}={result}");
                    }
                    else
                        Console.WriteLine("Can not be devided by zero");
                    break;
                default:
                    Console.WriteLine("Something going wrong");
                    break;
            }
            return result;
        }
    }
}