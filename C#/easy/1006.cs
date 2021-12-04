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
         
         double A, B, C, MEDIA;
         A = double.Parse(Console.ReadLine(), CI);
         B = double.Parse(Console.ReadLine(), CI);
         C = double.Parse(Console.ReadLine(), CI);
         
         MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;
         
         Console.WriteLine("MEDIA = " + MEDIA.ToString("F1",CI));
        
    }

}