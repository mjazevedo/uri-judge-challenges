using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
         
         CultureInfo CI = CultureInfo.InvariantCulture;
         
         double x1, x2, y1, y2, dist;
         string[] valores = Console.ReadLine().Split(' ');
         
         x1 = double.Parse(valores[0], CI);
         y1 = double.Parse(valores[1], CI);
         
         valores = Console.ReadLine().Split(' ');
         x2 = double.Parse(valores[0], CI);
         y2 = double.Parse(valores[1], CI);
         
         double p1 = x2 - x1;
         double p2 = y2 - y1;
         
         dist = Math.Pow(p1,2) + Math.Pow(p2,2);
         dist = Math.Sqrt(dist);
         
         Console.WriteLine(dist.ToString("F4",CI));
         
    }

}