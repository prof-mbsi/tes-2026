using System;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
    }
    public void AdicionarEstoque(int qtd)
    {
        Quantidade += qtd;
    }
    public void RemoverEstoque(int qtd)
    {
        if (qtd <= Quantidade)
        {
            Quantidade -= qtd;
        }
        else
        {
            Console.WriteLine("Estoque insuficiente");
        }
    }
    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    static void Main()
    {
        Produto p = new Produto();
        p.Nome = "Teclado";
        p.Preco = 100;
        p.Quantidade = 5;
        p.AdicionarEstoque(3);
        p.RemoverEstoque(2);
        p.ExibirDados();
        Console.WriteLine("Valor total: " + p.CalcularValorTotal());
    }
}