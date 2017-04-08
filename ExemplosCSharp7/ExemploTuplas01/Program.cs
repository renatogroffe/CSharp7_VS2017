using System;

namespace ExemploTuplas01
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int) parValores = (7, 49);
            Console.WriteLine($"Valor = {parValores.Item1} ----- " +
                              $"Quadrado = {parValores.Item2}");

            (int, int, int) dezenas = (10, 20, 30);
            Console.WriteLine($"Valor 1 = {dezenas.Item1} ----- " +
                              $"Valor 2 = {dezenas.Item2} ----- " +
                              $"Valor 3 = {dezenas.Item3}");

            var coordenadas = (latitude: "23.5505° S", longitude: "46.6333° W");
            Console.WriteLine($"São Paulo - " +
                              $"Latitude = {coordenadas.latitude} - " +
                              $"Longitude = {coordenadas.longitude}");

            Console.ReadKey();
        }
    }
}