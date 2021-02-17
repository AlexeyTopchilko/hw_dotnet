using System;
using System.Collections.Generic;
using System.Text;

namespace HW_05_Task3
{
    class Greeting
    {
        public static void GoodDay()
        {
            int currentHour = DateTime.Now.TimeOfDay.Hours;
            switch (currentHour)
            {
                case 9 :
                case 10:
                case 11:
                case 12:
                Console.WriteLine("Good Morning!");
                    break;

                case 13:
                case 14:
                case 15:
                Console.WriteLine("Good Day!");
                    break;

                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                        Console.WriteLine("Good evening!");
                    break;

                default:
                        Console.WriteLine("Somthing going wrong!");
                    break;
        }
    }
}
}