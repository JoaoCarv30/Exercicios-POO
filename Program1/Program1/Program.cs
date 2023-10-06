using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            float produto = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu nome, idade e altura (separados por espaço): ");
            string[] Vet = Console.ReadLine().Split(' ');

            string nome2 = Vet[0];
            int idade2 = int.Parse(Vet[1]);
            float altura2 = float.Parse(Vet[2]);

            Console.WriteLine("Nome: " + nome2);
            Console.WriteLine("Idade: " + idade2);
            Console.WriteLine("Altura: " + altura2);
        }
    }
}
