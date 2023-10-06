using Nome;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Digite o Nome da Primeira Pessoa: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da Primeira Pessoa: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome da Segunda Pessoa: ");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da Primeira Pessoa: ");
            y.Idade = int.Parse(Console.ReadLine());

            if(x.Idade > y.Idade)
            {
                Console.WriteLine("{0} é mais velha", x.Nome);
            }
            else
            {
                Console.WriteLine("{0} é mais velha", y.Nome);
            }


        }
    }
}