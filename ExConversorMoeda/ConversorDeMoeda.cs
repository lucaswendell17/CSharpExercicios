using System;
using System.Globalization;

namespace ExConversorMoeda{
    class ConversorDeMoeda{
        
        public static double Iof  = 6.0;
        public static double DolarParaReal(double dolar, double quantia){
            double total = dolar * quantia;
            return total = total + total * Iof / 100;
        }
    }
}