using System;

public class Produto{
    public string Nome;
    public double Preco;

    public void Exibir(){
        Console.WriteLine($"Produto: {Nome}, preço: {Preco}");
    }

    public void Atualizar(double NovoPreco){
        Preco = NovoPreco;
    }

    public Produto(string NomeDoProduto){
        Nome = NomeDoProduto;
    }

    public Produto(){

    }
}

class Program{
    static void Main(){
        Console.WriteLine("Olá Mundo!");
        Produto p1; 
        p1 = new Produto("Notebook");
        p1.Preco = 3500;
        p1.Exibir();
        Produto p2 = new Produto("Mouse");
        p2.Preco = 50;
        p2.Exibir();

        p1.Atualizar(3800);
        p1.Exibir();
        p2.Exibir();

        Produto p3 = new Produto();
        p3.Nome = "Garrafa Térmica";
        p3.Preco = 60;
        p3.Exibir();
    }
}