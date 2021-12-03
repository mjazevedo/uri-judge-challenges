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
         
         double pi = 3.14159;
         double area, raio;
         
         raio = double.Parse(Console.ReadLine());
         area = pi * (raio * raio);
         
         Console.WriteLine($"A=" + area.ToString("F4", CI));
    }

}