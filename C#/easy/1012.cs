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
         
         double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
         
         string[] valores = Console.ReadLine().Split(' ');
         A = double.Parse(valores[0],CI);
         B = double.Parse(valores[1],CI);
         C = double.Parse(valores[2],CI);
         
         triangulo = (A * C) / 2;
         circulo = 3.14159 * Math.Pow(C,2);
         trapezio = ((A + B) * C) / 2;
         quadrado = Math.Pow(B,2);
         retangulo = A * B;
         
         Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3",CI));
         Console.WriteLine("CIRCULO: " + circulo.ToString("F3",CI));
         Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3",CI));
         Console.WriteLine("QUADRADO: " + quadrado.ToString("F3",CI));
         Console.WriteLine("RETANGULO: " + retangulo.ToString("F3",CI));
    }

}