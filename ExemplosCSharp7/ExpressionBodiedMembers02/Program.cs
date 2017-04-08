using System;

namespace ExpressionBodiedMembers02
{
    public class Cotacao
    {
        public string Sigla { get; set; }
        public string NomeMoeda { get; set; }
        public DateTime UltimaAtualizacao { get; set; }

        private double _valor;

        /*public double Valor
        {
            get { return _valor; }
            set
            {
                _valor = value >= 0 ? value : 0;
            }
        }*/

        // Expressões lambda na definição da propriedade Valor
        public double Valor
        {
            get => _valor;
            set => _valor = value >= 0 ? value : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cotacao cotacao = new Cotacao();
            cotacao.Sigla = "USD";
            cotacao.NomeMoeda = "Dolar norte-americano";
            cotacao.UltimaAtualizacao =
                new DateTime(2017, 03, 10, 17, 59, 00);
            cotacao.Valor = 3.1435;

            Console.WriteLine(
                $"Moeda: {cotacao.NomeMoeda} ({cotacao.Sigla}) - " +
                $"Ultima Atualizacao: {cotacao.UltimaAtualizacao.ToString()} - " +
                $"Valor: {cotacao.Valor}");

            Console.ReadKey();
        }
    }
}