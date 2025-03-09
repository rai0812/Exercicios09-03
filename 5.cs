using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Responda com 'S' para SIM e 'N' para NÃO.");

        Console.Write("O animal é mamífero? ");
        char mamifero = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (mamifero == 'S')
        {
            Console.Write("O animal é quadrúpede? ");
            char quadrupede = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (quadrupede == 'S')
            {
                Console.Write("O animal é carnívoro? ");
                char carnivoro = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (carnivoro == 'S')
                {
                    Console.WriteLine("O animal escolhido foi o Leão.");
                }
                else
                {
                    Console.Write("O animal é herbívoro? ");
                    char herbivoro = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (herbivoro == 'S')
                        Console.WriteLine("O animal escolhido foi o Cavalo.");
                }
            }
            else
            {
                Console.Write("O animal é bípede? ");
                char bipede = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (bipede == 'S')
                {
                    Console.Write("O animal é onívoro? ");
                    char onivoro = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (onivoro == 'S')
                        Console.WriteLine("O animal escolhido foi o Homem.");
                    else
                        Console.WriteLine("O animal escolhido foi o Macaco.");
                }
                else
                {
                    Console.Write("O animal é voador? ");
                    char voador = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (voador == 'S')
                        Console.WriteLine("O animal escolhido foi o Morcego.");
                    else
                        Console.WriteLine("O animal escolhido foi a Baleia.");
                }
            }
        }
        else
        {
            Console.Write("O animal é ave? ");
            char ave = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (ave == 'S')
            {
                Console.Write("O animal é não voador? ");
                char naoVoador = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (naoVoador == 'S')
                {
                    Console.Write("O animal é tropical? ");
                    char tropical = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (tropical == 'S')
                        Console.WriteLine("O animal escolhido foi o Avestruz.");
                    else
                        Console.WriteLine("O animal escolhido foi o Pinguim.");
                }
                else
                {
                    Console.Write("O animal vive na água? ");
                    char aquatico = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (aquatico == 'S')
                        Console.WriteLine("O animal escolhido foi o Pato.");
                    else
                        Console.WriteLine("O animal escolhido foi a Águia.");
                }
            }
        }
    }
}
