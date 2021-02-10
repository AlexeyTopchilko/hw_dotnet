using System;
using System.IO;

namespace HW._02.image
{
    class Program
    {
        static void Main()
        {
            //1.Считываем текст из файла по пути C:\image.txt
            //2.Записать этот текст в строку textReaderResults
            //3.Освободим файл из которого считывали текст
            //4.Разбить строку на массив подстрок через пробелы
            //5.Создадим пустой массив под запись конвертированных байтов
            //6.Через цикл конвертируем текст в байты и запишем их в массив байтов
            //7.По завершении цикла запишем байты в файл по адресу C:\image.png
            StreamReader textReader = new StreamReader(@"C:\image.txt", true);
            string textReaderResults = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResults = textReaderResults.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResults.Length - 1];
            for (int i = 0; i < arrayOfTextResults.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResults[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\image.png", imageBytes);
        }
    }
}
