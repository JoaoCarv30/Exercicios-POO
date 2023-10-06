using Ex2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o Nome do Funcionário: ");
            funcionario.Nome = Console.ReadLine();


            Console.WriteLine("Digite o Salário Bruto do Funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario);

            Console.WriteLine("Digite a porcentagem para aumentar o salário : ");
            double pct = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(pct);

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(funcionario);







        }
    }
}