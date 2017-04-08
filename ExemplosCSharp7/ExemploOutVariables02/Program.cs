using System;

namespace ExemploOutVariables02
{
    class Program
    {
        private static void EfetuarValidacao(string strValorInteiro)
        {
            //int valor;
            //if (int.TryParse(strValorInteiro, out valor))
            if (int.TryParse(strValorInteiro, out _))
                Console.WriteLine($"{strValorInteiro} é um número inteiro válido...");
            else
                Console.WriteLine($"{strValorInteiro} não é um valor inteiro...");
        }

        static void Main(string[] args)
        {
            EfetuarValidacao("1000");
            EfetuarValidacao("057");
            EfetuarValidacao("5.70");

            Console.ReadKey();
        }
    }
}