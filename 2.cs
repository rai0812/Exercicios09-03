using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua altura em metros (ex: 1.75): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite seu sexo (M para masculino, F para feminino): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Pular linha para melhor visualização

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido. Use 'M' para masculino ou 'F' para feminino.");
            return;
        }

        Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2} kg");
    }
}

