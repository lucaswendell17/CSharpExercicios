using System;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(mat[i,i] + " ");
            }
            System.Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++){
             for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0){
                    count++;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Negative numbers: " + count);
            System.Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.WriteLine("Valor na linha {0} coluna {1} : {2}", i , j, mat[i,j]);
                }
            }
        }
    }
}
