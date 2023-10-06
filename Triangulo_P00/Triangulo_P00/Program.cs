using System;
using System.Globalization;
using Triangulo_P00;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Digite os lados do triângulo X ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




            Console.WriteLine("Digite os lados do triângulo Y ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areax = x.Area();
            double areay = y.Area();
            Console.WriteLine("Resultado de X:{0} ", areax);
            Console.WriteLine("Resultado de Y:{0} ", areay);




        }
    }
}