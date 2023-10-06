using Salario;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Digite o Nome do Primeiro Funcionário: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário do Primeiro Funcionário: ");
            x.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Nome do Segundo Funcionário: ");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário do Segundo Funcionário: ");
            y.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x.Salario + y.Salario)/2;
            Console.WriteLine(media);



        }
    }
}