using System;
using System.Globalization;

namespace CsE21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 21
            Console.Write("Conta de divisão Ex: 5(Dividendo) *Espaço* 8(Divisor)\n\nQuantos casos deseja testar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"\nCaso ({i}): ");
                string[] v = Console.ReadLine().Split(' ');
                double v1 = double.Parse(v[0]);
                double v2 = double.Parse(v[1]);
                double d = v1 / v2;
                if (v2 == 0)
                    Console.WriteLine("\nDIVISÃO IMPOSSÍVEL");
                else Console.WriteLine("Resultado: " + d.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
