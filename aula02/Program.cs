using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Funcionou!");

        //Exemplo 1:
        Console.Write("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine($"{idade}");
        if (idade > 18)
        {
            Console.WriteLine("Você é maior de idade!");
        }
        else
        {
            Console.WriteLine("Você não é maior de idade!");
        }

        //Exemplo 2:
        Console.Write("Informe número de 1 a 3: ");
        int num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Você escolheu a opção um!");
                break;
            case 2:
                Console.WriteLine("Você escolheu a opção dois!");
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção três!");
                break;
            default:
                Console.WriteLine("Opção incorreta!");
                break;
        }

        //Exercício 1 (maior, menor, double):
        Console.Write("Informe um valor double: ");
        double valor = double.Parse(Console.ReadLine());
        if (valor > 100)
        {
            Console.WriteLine("Maior que R$100!");
        }
        else if (valor < 100)
        {
            Console.WriteLine("Menor que R$100!");
        }
        else
        {
            Console.WriteLine("Você informou R$100!");
        }

        //Exercício 2 (Menu):
        Console.WriteLine("--- Menu ---");
        Console.Write("A: Café, B: Chá, C: Refrigerante: ");
        string opcaoMenu = Console.ReadLine().ToUpper();
        switch (opcaoMenu)
        {
            case "A":
                Console.WriteLine("Café");
                break;
            case "B":
                Console.WriteLine("Chá");
                break;
            case "C":
                Console.WriteLine("Refrigerante");
                break;
            default:
                Console.WriteLine("Opção indisponível!");
                break;
        }

        //Exemplo 3 (for):
        for (int contador = 0; contador < 10; contador += 2)
        {
            Console.WriteLine($"{contador}");
        }

        //Exercício 3 (tabuada):
        Console.Write("Informe número para mostrar a tabuada: ");
        int tabuada = int.Parse(Console.ReadLine());
        if (tabuada < 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} * {i} = {tabuada * i}");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }

        //Exercício 4 (potência de 2):
        Console.Write("Informe valor para calcular a potência de 2: ");
        int potencia = int.Parse(Console.ReadLine());
        int resultado = 1;
        for (int i = 1; i <= potencia; i++)
        {
            resultado *= 2;
        }
        Console.WriteLine($"2 ^ {potencia}: {resultado}");

        //Exercício 5 (while):
        Console.Write("Informe valor: ");
        int x = int.Parse(Console.ReadLine());
        while (x != 0)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} é par!");
            }
            else
            {
                Console.WriteLine($"{x} é ímpar!");
            }
            Console.Write("Informe valor: ");
            x = int.Parse(Console.ReadLine());
        }
    }
}