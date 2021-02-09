using System;

namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte VarByte = 100;

            // примеры неявного преобразования

            short VarShort = VarByte;
            int VarInt = VarShort;
            long VarLong = VarInt;
            Console.WriteLine($"Byte={VarByte}, Short={VarShort},Int={VarInt},Long={VarLong} ");
            VarLong = 270;

            // примеры явного преобразования

            VarInt = (int)VarLong;
            VarShort = (short)VarLong;
            VarByte = (byte)VarShort;
            Console.WriteLine($"Byte={VarByte}, Short={VarShort},Int={VarInt},Long={VarLong} ");

            // примеры упаковки

            object BoxingVarByte = VarByte;
            object BoxingVarShort = VarShort;
            object BoxingVarLong = VarLong;

            // примеры распаковки

            VarByte = (byte)BoxingVarByte;
            VarShort = (short)BoxingVarShort;
            VarLong = (long)BoxingVarLong;
            Console.WriteLine($"Byte={VarByte}, Short={VarShort},Long={VarLong} ");
        }
    }
}
