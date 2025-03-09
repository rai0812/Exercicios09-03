using System;

class Program
{
    static void Main()
    {
        int[] D = new int[20];

        
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Digite os 20 elementos do vetor D:");
        for (int i = 0; i < D.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            D[i] = int.Parse(Console.ReadLine());
        }

      
        Console.WriteLine("\nVetor compactado (elementos maiores que N):");
        for (int i = 0; i < D.Length; i++)
        {
            if (D[i] > N)
            {
                Console.Write(D[i] + " ");
            }
        }
    }
}