using System;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; private set; }
    public double PrecoComDesconto { get; private set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        PrecoComDesconto = preco;
        Quantidade = quantidade;
    }

    public void AplicarDesconto(double percentual)
    {
        PrecoComDesconto = Preco - (Preco * (percentual / 100.0));
        Console.WriteLine($"Desconto aplicado! Novo preço: R${PrecoComDesconto:F2}");
    }

    public void RemoverDesconto()
    {
        PrecoComDesconto = Preco;
        Console.WriteLine("Desconto removido. Preço original restaurado.");
    }

    public double ValorTotalEmEstoque()
    {
        return PrecoComDesconto * Quantidade;
    }

    public override string ToString()
    {
        return $"Produto: {Nome}, Preço Original: R${Preco:F2}, Preço Atual: R${PrecoComDesconto:F2}, " +
               $"Quantidade: {Quantidade}, Valor em Estoque: R${ValorTotalEmEstoque():F2}";
    }
}
