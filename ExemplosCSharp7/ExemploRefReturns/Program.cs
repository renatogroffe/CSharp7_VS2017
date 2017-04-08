using System;

namespace ExemploRefReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseExemplo exemplo = new ClasseExemplo();
            exemplo.Incrementar();
            Console.WriteLine(exemplo.ObterValorContador());

            ref int teste = ref exemplo.ObterContador();
            teste++;
            Console.WriteLine(exemplo.ObterValorContador());
            Console.ReadKey();
        }
    }
}