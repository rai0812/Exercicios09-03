using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a venda média mensal do produto: ");
        int vendaMediaMensal = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço atual do produto: R$ ");
        double precoAtual = double.Parse(Console.ReadLine());

        double novoPreco = precoAtual;

        if (vendaMediaMensal < 500 && precoAtual < 30.00)
        {
            novoPreco *= 1.10; // Aumento de 10%
            Console.WriteLine("O preço foi aumentado em 10%.");
        }
        else if (vendaMediaMensal >= 500 && precoAtual >= 30.00)
        {
            novoPreco *= 0.80; // Redução de 20%
            Console.WriteLine("O preço foi reduzido em 20%.");
        }
        else
        {
            Console.WriteLine("O preço permanece o mesmo.");
        }

        Console.WriteLine($"Novo preço do produto: R$ {novoPreco:F2}");
    }
}