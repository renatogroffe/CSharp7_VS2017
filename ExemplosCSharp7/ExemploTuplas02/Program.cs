using System;

namespace ExemploTuplas02
{
    class Program
    {
        private static (double tempFahrenheit, double tempCelsius, double tempKelvin)
            ConverterTemperaturas(double valorFahrenheit)
        {
            double retCelsius = Math.Round((valorFahrenheit - 32) / 1.8, 2);
            double retKelvin = retCelsius + +273.15;

            return (valorFahrenheit, retCelsius, retKelvin);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de temperaturas");

            // Exemplo simples
            var resultado1 = ConverterTemperaturas(86);
            Console.WriteLine($"Fahrenheit = {resultado1.tempFahrenheit} - " +
                              $"Celsius = {resultado1.tempCelsius} - " +
                              $"Kelvin = {resultado1.tempKelvin}");

            // Exemplo 1 - Desconstrução
            (double resFahrenheit2, double resCelsius2, double resKelvin2) =
                ConverterTemperaturas(32);
            Console.WriteLine($"Fahrenheit = {resFahrenheit2} - " +
                              $"Celsius = {resCelsius2} - " +
                              $"Kelvin = {resKelvin2}");

            // Exemplo 2 - Desconstrução
            double valorFahrenheit3 = 212;
            (_, double resCelsius3, double resKelvin3) =
                ConverterTemperaturas(valorFahrenheit3);
            Console.WriteLine($"Fahrenheit = {valorFahrenheit3} - " +
                              $"Celsius = {resCelsius3} - " +
                              $"Kelvin = {resKelvin3}");

            Console.ReadKey();
        }
    }
}