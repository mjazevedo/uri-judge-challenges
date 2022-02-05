using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0; 
            double B = 0;
            double C = 0;

            string[] valor = Console.ReadLine().Split(' ');

            A = double.Parse(valor[0]);
            B = double.Parse(valor[1]);
            C = double.Parse(valor[2]);

            double delta = Math.Pow(B, 2) - 4 * A * C;

            if (delta <= 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double r1 = ((-B + Math.Sqrt(delta)) / (2 * A));
                Console.WriteLine("R1 = " + r1.ToString("F5"));

                double r2 = ((-B - Math.Sqrt(delta)) / (2 * A));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            }
        }
    }
}