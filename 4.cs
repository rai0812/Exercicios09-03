using System;

class Program
{
    static void Main()
    {
       
        const int horasSemanais = 40;
        const int semanasNoMes = 4;
        int horasMensais = horasSemanais * semanasNoMes;

        
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.Write("Digite o salário por hora: R$ ");
        double salarioPorHora = double.Parse(Console.ReadLine());

        double salarioTotal;

        if (horasTrabalhadas > horasMensais)
        {
            int horasExtras = horasTrabalhadas - horasMensais;
            double valorHoraExtra = salarioPorHora * 1.5; // 50% de acréscimo
            salarioTotal = (horasMensais * salarioPorHora) + (horasExtras * valorHoraExtra);
        }
        else
        {
            salarioTotal = horasTrabalhadas * salarioPorHora;
        }

        Console.WriteLine($"Salário total do funcionário: R$ {salarioTotal:F2}");
    }
}
