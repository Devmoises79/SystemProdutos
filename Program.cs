using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao software de Cadastro de Produtos!");
        Console.WriteLine("--- Cadastro de Produtos ---");
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Digite a quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        bool executando = true;
        while (executando)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1 - Mostrar informações do produto");
            Console.WriteLine("2 - Aplicar desconto");
            Console.WriteLine("3 - Remover desconto");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine(produto);
                    break;

                case "2":
                    Console.Write("Digite o percentual de desconto: ");
                    double percentual = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
                    produto.AplicarDesconto(percentual);
                    break;

                case "3":
                    produto.RemoverDesconto();
                    break;

                case "4":
                    executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
