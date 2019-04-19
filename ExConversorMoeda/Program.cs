using System;
using System.Globalization;

namespace ExConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(dolar, quantia);
            Console.WriteLine("Valor a ser pago em Reais: " +resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
