using System;

namespace ThrowExpressions
{
    public class Temperatura
    {
        private double _celsius;

        /*public double Celsius
        {
            get
            {
                return _celsius;
            }
            set
            {
                if (value >= -273.15)
                    _celsius = value;
                else
                    throw new Exception("Temperatura inválida!");
            }
        }*/
        /*public double Celsius
        {
            get
            {
                return _celsius;
            }
            set
            {
                _celsius = value >= -273.15 ? value : throw new Exception("Temperatura inválida!");
            }
        }*/
        public double Celsius
        {
            get => _celsius;
            set => _celsius = value >= -273.15 ? value : throw new Exception("Temperatura inválida!");
        }

        public double Fahrenheit
        {
            get => ((9.0 / 5.0) * _celsius) + 32;
        }
    }
}