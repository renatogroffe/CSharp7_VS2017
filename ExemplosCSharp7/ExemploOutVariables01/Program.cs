using System;

namespace ExemploOutVariables01
{
    class Program
    {
        private static void CalcularDiasVividos(string strDataNasc)
        {
            //DateTime dataNasc;
            //if (DateTime.TryParse(strDataNasc, out dataNasc))
            //if (DateTime.TryParse(strDataNasc, out DateTime dataNasc))
            if (DateTime.TryParse(strDataNasc, out var dataNasc))
            {
                DateTime dataAtual = DateTime.Now.Date;
                Console.WriteLine($"Data Atual: { dataAtual: dd/MM/yyyy}");
                Console.WriteLine($"Data de Nascimento: { dataNasc: dd/MM/yyyy}");
                TimeSpan intervalo = dataAtual.Subtract(dataNasc);
                Console.WriteLine($"Quantidade de dias vividos: { intervalo.TotalDays}");
            }
            else
            {
                Console.WriteLine($"Data invalida: {strDataNasc}");
            }

            Console.Write(Environment.NewLine);
        }
    
        static void Main(string[] args)
        {
            CalcularDiasVividos("07/03/2017");
            CalcularDiasVividos("ERRO");
            CalcularDiasVividos("31/01/1990");

            Console.ReadKey();
        }
    }
}