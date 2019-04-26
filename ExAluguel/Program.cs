using System;

namespace ExAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?  ");
            int quarto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quarto; i++)
            {
                System.Console.WriteLine("Aluguel #"+i);
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int qto = int.Parse(Console.ReadLine());
                vect[qto] = new Estudante(nome, email);
            }

            System.Console.WriteLine("Quartos Ocupados: ");
            System.Console.WriteLine();

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                    System.Console.WriteLine(i + ": " + vect[i]);
            }

        }
    }
}
