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
         
         int X;
         double Y, consumo;
         
         X = int.Parse(Console.ReadLine());
         Y = double.Parse(Console.ReadLine(),CI);
         
         consumo = (double)X / Y;
         
         Console.WriteLine(consumo.ToString("F3",CI) + " km/l");

    }

}