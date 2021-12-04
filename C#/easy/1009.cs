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
         
        string vendedor;
        double salario, vendas, total;
         
        vendedor = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CI);
        vendas = double.Parse(Console.ReadLine(), CI);
         
        total = salario + (0.15 * vendas);
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2",CI));
    }
}