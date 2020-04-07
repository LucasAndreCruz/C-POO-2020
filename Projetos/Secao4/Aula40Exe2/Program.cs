using System;
using System.Globalization;

namespace Aula40Exe2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Aula 40");
            Console.WriteLine("Exercício 02");
            Console.WriteLine("Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Funcionario primeiro, segundo;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            primeiro.Nome = "Carlos Silva";
            primeiro.Salario = 6300.00;
            Console.WriteLine("Nome: " + primeiro.Nome);
            Console.WriteLine("Salário: " + primeiro.Salario.ToString("F2",CultureInfo.InvariantCulture) + "\n");

            Console.WriteLine("Dados do segundo funcionário:");
            segundo.Nome = "Ana Marques";
            segundo.Salario = 6700.00;
            Console.WriteLine("Nome: " + segundo.Nome);
            Console.WriteLine("Salário: " + segundo.Salario.ToString("F2", CultureInfo.InvariantCulture) + "\n");

            double media = (primeiro.Salario + segundo.Salario) / 2;

            Console.WriteLine("Salário médio = "+media.ToString("F2", CultureInfo.InvariantCulture));
            



        }
    }
}
