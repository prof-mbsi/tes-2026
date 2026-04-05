using System;

public class Produto
{
    public string Nome;
    public double Preco;
    public void Exibir()
    {
        Console.WriteLine(Nome + " - " + Preco);
    }
}
/* Pedido 1:1
public class Pedido
{
    public Produto Produto;
    public int Quantidade;
    public void ExibirPedido()
    {
        Console.WriteLine("Produto: " + Produto.Nome);
        Console.WriteLine("Preço: " + Produto.Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Total: " + Produto.Preco * Quantidade);
    }
}
*/
/* Pedido 1:N */
public class Pedido
{
    public List<Produto> Produtos = new List<Produto>();
    public void AdicionarProduto(Produto p)
    {
        Produtos.Add(p);
    }
    public void ExibirPedido()
    {
        foreach (Produto p in Produtos)
        {
            Console.WriteLine(p.Nome + " - " + p.Preco);
        }
    }
    public double CalcularTotal()
    {
        double total = 0;
        foreach (Produto p in Produtos)
        {
            total += p.Preco;
        }
        return total;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        p.Nome = "Teclado";
        p.Preco = 100;

        /* Pedido 1:1
        Pedido ped = new Pedido();
        ped.Produto = p;
        ped.Quantidade = 2;
        ped.ExibirPedido();
        */

        Produto p1 = new Produto();
        p1.Nome = "Mouse";
        p1.Preco = 50;
        Produto p2 = new Produto();
        p2.Nome = "Teclado";
        p2.Preco = 100;
        Pedido pedido = new Pedido();
        pedido.AdicionarProduto(p1);
        pedido.AdicionarProduto(p2);
        pedido.ExibirPedido();
        Console.WriteLine($"Total do pedido: {pedido.CalcularTotal()}");
    }
}