using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte VarSbyte = 1;
            System.SByte VarSbyteClr = 1;
            Console.WriteLine(VarSbyte.GetType());
            Console.WriteLine(VarSbyteClr.GetType());


            short VarShort = 2;
            System.Int16 VarShortClr = 2;
            Console.WriteLine(VarShort.GetType());
            Console.WriteLine(VarShortClr.GetType());

            int VarInt = 3;
            System.Int32 VarIntClr = 3;
            Console.WriteLine(VarInt.GetType());
            Console.WriteLine(VarIntClr.GetType());

            long VarLong = 4;
            System.Int64 VarLongClr = 4;
            Console.WriteLine(VarLong.GetType());
            Console.WriteLine(VarLongClr.GetType());

            byte VarByte = 5;
            System.Byte VarByteClr = 5;
            Console.WriteLine(VarByte.GetType());
            Console.WriteLine(VarByteClr.GetType());

            ushort VarUshort = 6;
            System.UInt16 VarUshortClr = 6;
            Console.WriteLine(VarUshort.GetType());
            Console.WriteLine(VarUshortClr.GetType());

            char VarChar = 'H';
            System.Char VarCharCLr = 'H';
            Console.WriteLine(VarChar.GetType());
            Console.WriteLine(VarCharCLr.GetType());

            string VarString = "Hello Vadzim!";
            string VarStringClr = "Hello Vadzim";
            Console.WriteLine(VarString.GetType());
            Console.WriteLine(VarStringClr.GetType());

            object VarObj = 7;
            System.Object VarObjClr = 7;
            Console.WriteLine(VarObj.GetType());
            Console.WriteLine(VarObjClr.GetType());




        }
    }
}
