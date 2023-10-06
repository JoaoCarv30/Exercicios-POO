using System;
using System.Globalization;


namespace EX42
{
     class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos( int quantidade)
        {

            Quantidade += quantidade;


        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ",$" 
                +Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade : "
                +Quantidade + ","
                +"Valor total em estoque: "
                +ValorTotalEmEstoque();
        }
    }
}
