using System; 

class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
         
         int horas, minutos, resto, segundos;
         
         int n = int.Parse(Console.ReadLine());
         
         horas = n / 3600;
         resto = n % 3600;
         
         minutos = resto / 60;
         segundos = resto % 60;
         
         Console.WriteLine(horas + ":" + minutos + ":" + segundos);

    }

}