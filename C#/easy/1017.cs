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
         
         int tempo, vmedia;
         double qnt;
         
         tempo = int.Parse(Console.ReadLine());
         vmedia = int.Parse(Console.ReadLine());
         
         qnt = (double)(tempo * vmedia) / 12.0;
         
         Console.WriteLine(qnt.ToString("F3",CI));

    }

}