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
         
         double R, volume;
         double pi = 3.14159;
         
         R = double.Parse(Console.ReadLine());
         
         volume = (4/3.0) * pi * Math.Pow(R,3);
         
         Console.WriteLine("VOLUME = " + volume.ToString("F3",CI));
    }

}