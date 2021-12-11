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
         
         int cod1, cod2, qnt1, qnt2;
         double preco1, preco2, total;
         
         string[] valores = Console.ReadLine().Split(' ');
         
         cod1 =  int.Parse(valores[0]);
         qnt1 = int.Parse(valores[1]);
         preco1 = double.Parse(valores[2],CI);
         
         valores = Console.ReadLine().Split(' ');
         
         cod2 =  int.Parse(valores[0]);
         qnt2 = int.Parse(valores[1]);
         preco2 = double.Parse(valores[2],CI);
         
         total = (preco1 * qnt1) + (preco2 * qnt2);
         
         Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CI));

    }

}