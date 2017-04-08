using System;
using System.Threading;

namespace ExemploLocalFunctions01
{
    class Program
    {
        static void Main(string[] args)
        {
            void ExibirHorarioAtual()
            {
                Console.WriteLine(
                    $"Horário atual: {DateTime.Now.ToString("HH:mm:ss")}");

            }

            ExibirHorarioAtual();

            Console.WriteLine("Aguarde alguns segundos...");
            Random r = new Random();
            Thread.Sleep(new Random().Next(3000, 6000));

            ExibirHorarioAtual();
            Console.ReadKey();
        }
    }
}