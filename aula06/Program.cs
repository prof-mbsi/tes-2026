using System;
using System.Collections.Generic;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void Exibir()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Total: " + (Preco * Quantidade));
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        int opcao = 0;

        while (opcao != 7)
        {
            Console.WriteLine("\n1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Buscar");
            Console.WriteLine("5 - Remover");
            Console.WriteLine("6 - Total");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Produto p = new Produto();

                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (preco < 0)
                {
                    Console.WriteLine("Preço inválido!");
                    continue;
                }

                p.Preco = preco;

                Console.Write("Quantidade: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                produtos.Add(p);

                Console.WriteLine("Produto cadastrado!");
            }
            else if (opcao == 2)
            {
                foreach (Produto p in produtos)
                {
                    Console.WriteLine("------------");
                    p.Exibir();
                }
            }
            else if (opcao == 4)
            {
                Console.Write("Digite o nome para buscar: ");
                string busca = Console.ReadLine();

                bool encontrado = false;

                foreach (Produto p in produtos)
                {
                    if (p.Nome.ToLower() == busca.ToLower())
                    {
                        p.Exibir();
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else if (opcao == 5)
            {
                Console.Write("Digite o nome para remover: ");
                string nome = Console.ReadLine();

                Produto remover = null;

                foreach (Produto p in produtos)
                {
                    if (p.Nome.ToLower() == nome.ToLower())
                    {
                        remover = p;
                        break;
                    }
                }

                if (remover != null)
                {
                    produtos.Remove(remover);
                    Console.WriteLine("Produto removido!");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else if (opcao == 6)
            {
                double total = 0;

                foreach (Produto p in produtos)
                {
                    total += p.Preco * p.Quantidade;
                }

                Console.WriteLine("Total geral: " + total);
            }
        }
    }
}