using System;

namespace ExemploPatternMatching
{
    class Program
    {
        //public static void ExibirInformacoesCotacao(Cotacao cotacao)
        //{
        //    double valorCotacao = 0;
        //    if (cotacao is CotacaoDolar)
        //    {
        //        valorCotacao =
        //            ((CotacaoDolar)cotacao).ValorComercial;
        //    }
        //    else if (cotacao is CotacaoEuro)
        //    {
        //        valorCotacao =
        //            ((CotacaoEuro)cotacao).ValorCotacao;
        //    }

        //    Console.WriteLine(new String('-', 40));
        //    Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
        //    Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
        //    Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
        //    Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        //}

        //public static void ExibirInformacoesCotacao(Cotacao cotacao)
        //{
        //    double valorCotacao = 0;
        //    if (cotacao is CotacaoDolar dolar)
        //        valorCotacao = dolar.ValorComercial;
        //    else if (cotacao is CotacaoEuro euro)
        //        valorCotacao = euro.ValorCotacao;

        //    Console.WriteLine(new String('-', 40));
        //    Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
        //    Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
        //    Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
        //    Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        //}

        public static void ExibirInformacoesCotacao(Cotacao cotacao)
        {
            double valorCotacao;
            switch (cotacao)
            {
                case CotacaoDolar dolar:
                    valorCotacao = dolar.ValorComercial;
                    break;
                case CotacaoEuro euro:
                    valorCotacao = euro.ValorCotacao;
                    break;
                default:
                    valorCotacao = 0;
                    break;
            }

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
            Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
            Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
            Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        }

        public static void DecisaoViagem(Cotacao cotacao)
        {
            switch (cotacao)
            {
                case CotacaoDolar dolar when (dolar.ValorTurismo <= 3):
                    Console.WriteLine("Hora de viajar para o EUA!");
                    break;
                case CotacaoDolar dolar when (dolar.ValorTurismo > 3):
                    Console.WriteLine("Melhor ficar em casa!");
                    break;
                case CotacaoEuro euro when (euro.ValorCotacao <= 3):
                    Console.WriteLine("Hora de viajar para Europa!");
                    break;
                case CotacaoEuro euro when (euro.ValorCotacao > 3):
                    Console.WriteLine("Melhor ficar em casa!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            CotacaoDolar dolar = new CotacaoDolar();
            dolar.DataCotacao = new DateTime(2017, 3, 24);
            dolar.ValorComercial = 3.1083;
            dolar.ValorTurismo = 3.2700;
            ExibirInformacoesCotacao(dolar);
            DecisaoViagem(dolar);

            CotacaoEuro euro = new CotacaoEuro();
            euro.DataCotacao = new DateTime(2017, 3, 24);
            euro.ValorCotacao = 3.3695;
            ExibirInformacoesCotacao(euro);
            DecisaoViagem(euro);

            Console.ReadKey();
        }
    }
}