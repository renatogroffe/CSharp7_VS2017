using System;

namespace ExemploPatternMatching
{
    public abstract class Cotacao
    {
        public DateTime DataCotacao { get; set; }
        public abstract string SiglaMoeda { get; }
        public abstract string NomeMoeda { get; }
    }

    public class CotacaoDolar : Cotacao
    {
        public override string SiglaMoeda
        { get { return "Dólar norte-americano"; } }

        public override string NomeMoeda
        { get { return "USD"; } }

        public double ValorComercial { get; set; }
        public double ValorTurismo { get; set; }
    }

    public class CotacaoEuro : Cotacao
    {
        public override string SiglaMoeda
        { get { return "Euro"; } }

        public override string NomeMoeda
        { get { return "EUR"; } }

        public double ValorCotacao { get; set; }
    }
}