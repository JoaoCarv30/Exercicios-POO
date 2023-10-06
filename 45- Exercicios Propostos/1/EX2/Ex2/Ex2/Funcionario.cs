using System;

namespace Ex2
{
     class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;






        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return "Nome:" + Nome + "\n" + "Salario Bruto: " + SalarioBruto + "\nSalarioLiquido: " + SalarioLiquido();
        }





    }
}
