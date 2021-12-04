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
         
         double A, B, media;
         A = double.Parse(Console.ReadLine(), CI);
         B = double.Parse(Console.ReadLine(), CI);
         
         media = ((A * 3.5) + (B * 7.5)) / 11;

         Console.WriteLine("MEDIA = " + media.ToString("F5",CI));
    }

}