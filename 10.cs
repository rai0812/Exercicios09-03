using System;

class Program
{
    static void Main()
    {
        
        int[,] A = new int[4, 4];
        int somaHachurada = 0;

        
        Console.WriteLine("Digite os elementos da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento A[{i + 1},{j + 1}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

       
        for (int i = 1; i < 4; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                somaHachurada += A[i, j];
            }
        }

       
        Console.WriteLine($"A soma das partes hachuradas é: {somaHachurada}");
    }
}