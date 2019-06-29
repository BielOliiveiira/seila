using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    class Conversor
    {
        //Nomes das variáveis sempre em minúsculos
        private double tempCelsius;
        private double tempFahrenheit;
        public double TempCelsius { get => tempCelsius; set => tempCelsius = value; }
        public double TempFahrenheit { get => tempFahrenheit; set => tempFahrenheit = value; }

        public double ConverterParaCelsius(){
            //Método que converte de Fahrenheit para Celsius
            //Formula matemática para conversão de Fahrenheit pra Celsius
            double celsius = (TempFahrenheit - 32) / 1.8;
            return (celsius);
        }
        public double ConverterParaFahrenheit()
        {
            //Método que converte de Celsius para Fahrenheit
            //Formula matemática para conversão de Celsius para Fahrenheit
            double fahrenheit = 1.8 * tempCelsius + 32;
            return (fahrenheit);
        }
    }
}
