using System;
using System.Threading.Tasks;

namespace ExemploValueTask
{
    class Program
    {
        private static int _tempoEsperaInicial;

        //private static async Task<int> EsperaAleatoria()
        private static async ValueTask<int> EsperaAleatoria()
        {
            if (_tempoEsperaInicial == 0)
            {
                _tempoEsperaInicial = new Random().Next(5000, 10000);
                await Task.Delay(_tempoEsperaInicial);
            }

            return _tempoEsperaInicial;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Criando a primeira task");
            var task1 = EsperaAleatoria();
            Console.WriteLine("Retorno da primeira task: " + task1.Result);

            Console.WriteLine("Criando a segunda task");
            var task2 = EsperaAleatoria();
            Console.WriteLine("Retorno da segunda task: " + task2.Result);

            Console.ReadKey();
        }
    }
}