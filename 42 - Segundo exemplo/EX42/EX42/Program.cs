using EX42;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto : ");

            Console.Write("Nome : ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + produto);


            Console.WriteLine("Digite quantos produtos voce deseja adicionar: ");
            int qtde = int.Parse(Console.ReadLine());


            produto.AdicionarProdutos(qtde);
            Console.WriteLine("Dados do Produto Atualizados : " + produto);

            Console.WriteLine("Digite quantos produtos voce deseja Remover: ");
            int qtdeRemove = int.Parse(Console.ReadLine());


            produto.RemoverProdutos(qtdeRemove);
            Console.WriteLine("Dados do Produto Atualizados : " + produto);


        }
    }
} 