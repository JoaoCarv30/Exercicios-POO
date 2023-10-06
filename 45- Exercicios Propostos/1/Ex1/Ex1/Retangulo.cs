using System;


namespace Ex1
{
     class Retangulo
    {
        public double Base;
        public double Altura;



        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return (2 * Base) + (2 * Altura);
        }

        public double Diagonal()
        {

            
            double diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            return diagonal;
            
        }
    }
}
