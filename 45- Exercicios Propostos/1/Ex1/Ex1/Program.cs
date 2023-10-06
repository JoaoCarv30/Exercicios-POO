using Ex1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a base do retangulo: ");
            retangulo.Base = double.Parse(Console.ReadLine());

            Console.Write("Digite a Altura do Retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A area é: " + retangulo.Area());

            Console.WriteLine("O perimetro é: " + retangulo.Perimetro());

            Console.WriteLine("A Diagonal é: " + retangulo.Diagonal());



        }
    }
}