using System;

namespace Aula40Exe1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Aula 40");
            Console.WriteLine("Exercício 01");
            Console.WriteLine("Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Pessoa primeira = new Pessoa();
            Pessoa segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            primeira.Nome = "Maria";
            primeira.Idade = 17;
            Console.WriteLine("Nome: " + primeira.Nome);
            Console.WriteLine("Idade: " + primeira.Idade);

            Console.WriteLine("\nDados da segunda pessoa:");
            segunda.Nome = "Joao";
            segunda.Idade = 16;
            Console.WriteLine("Nome: " + segunda.Nome);
            Console.WriteLine("Idade: " + segunda.Idade+"\n");

            if(primeira.Idade > segunda.Idade) {
                Console.WriteLine("Pessoa mais velha: " + primeira.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + segunda.Nome);
            }


        }
    }
}
