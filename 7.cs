using System;

class Program
{
    static void Main()
    {
        int[] gabarito = new int[5];
        int[] aposta = new int[10];
        int acertos = 0;

       
        Console.WriteLine("Digite os 5 números do gabarito da LOTO:");
        for (int i = 0; i < gabarito.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            gabarito[i] = int.Parse(Console.ReadLine());
        }

       
        Console.WriteLine("\nDigite os 10 números da aposta:");
        for (int i = 0; i < aposta.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            aposta[i] = int.Parse(Console.ReadLine());
        }

      
        foreach (int numAposta in aposta)
        {
            foreach (int numGabarito in gabarito)
            {
                if (numAposta == numGabarito)
                {
                    acertos++;
                    break; 
                }
            }
        }

      
        Console.WriteLine($"\nO apostador fez {acertos} pontos.");
    }
}

