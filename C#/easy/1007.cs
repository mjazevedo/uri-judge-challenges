using System; 

class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
         
         int A, B, C, D, DIFERENCA;
         
         A = int.Parse(Console.ReadLine());
         B = int.Parse(Console.ReadLine());
         C = int.Parse(Console.ReadLine());
         D = int.Parse(Console.ReadLine());
         
         DIFERENCA = (A * B - C * D);
         
         Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }

}