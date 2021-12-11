using System; 

class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
         
         int a, b, c, maiorab;
         string[] valor = Console.ReadLine().Split(' ');
         
         a = int.Parse(valor[0]);
         b = int.Parse(valor[1]);
         c = int.Parse(valor[2]);
         
         maiorab = (a + b + Math.Abs(a - b)) / 2;
         maiorab = (maiorab + c + Math.Abs(maiorab - c)) / 2;
         
         Console.WriteLine(maiorab + " eh o maior");

    }

}