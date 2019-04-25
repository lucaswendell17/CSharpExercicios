using System;
using System.Globalization;

namespace ExContaBancaria
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string  Nome { get; set; }
        public double  Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
           Deposito(depositoInicial);
        }

        public void Deposito(double quantia){
            Saldo += quantia;
        }

        public void Saque(double quantia){
            Saldo -= quantia + 5.00;
        }

        public override string ToString(){
            return "Conta: "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                +Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}