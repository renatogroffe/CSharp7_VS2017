using System;
using System.Linq;

namespace ExemploLocalFunctions02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando Delegate (mais custoso que a Local Function)
            //Func<string, string> Inverter = valor => new string(valor.ToCharArray().Reverse().ToArray());

            //string Inverter(string valor)
            //{
            //    return new string(
            //        valor.ToCharArray().Reverse().ToArray());
            //}

            string Inverter(string valor) =>
                new string(valor.ToCharArray().Reverse().ToArray());

            string texto;

            texto = "Utilizando o C# 7.0";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            texto = "Local Function";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            Console.ReadKey();
        }
    }
}