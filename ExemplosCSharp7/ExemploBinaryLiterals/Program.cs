using System;

namespace ExemploBinaryLiterals
{
    class Program
    {
        private const int LETRA_Y_BIN = 0b01011001; // 89
        private const int LETRA_Z_BIN = 0B01011010; // 90

        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de uso - Binary Literals");
            Console.WriteLine($"Y = {LETRA_Y_BIN}");
            Console.WriteLine($"Z = {LETRA_Z_BIN}");
            Console.ReadKey();
        }
    }
}