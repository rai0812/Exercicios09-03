using System;

class Program
{
    static void Main()
    {
      
        double[] notas = new double[7];

        
        Console.WriteLine("Digite as 7 notas dos juízes (de 0 a 10):");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota do juiz {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        
        double maiorNota = notas[0];
        double menorNota = notas[0];

        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > maiorNota)
                maiorNota = notas[i];
            if (notas[i] < menorNota)
                menorNota = notas[i];
        }

        
        double somaFinal = 0;
        int contagem = 0;

        foreach (double nota in notas)
        {
            if (nota != maiorNota && nota != menorNota)
            {
                somaFinal += nota;
                contagem++;
            }
        }

        
        double notaFinal = somaFinal / contagem;
        Console.WriteLine($"A nota final do atleta é: {notaFinal:F2}");
    }
}
