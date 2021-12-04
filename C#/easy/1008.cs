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
         
         int num_funcionario, horas_trabalhadas;
         double salario_hora, salario_total;
         
         num_funcionario = int.Parse(Console.ReadLine());
         horas_trabalhadas = int.Parse(Console.ReadLine());
         salario_hora = double.Parse(Console.ReadLine(), CI);
         
         salario_total = horas_trabalhadas * salario_hora;
         
         Console.WriteLine($"NUMBER = {num_funcionario}");
         Console.WriteLine("SALARY = U$ " + salario_total.ToString("F2",CI));

    }

}