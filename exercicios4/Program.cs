using System;

class Program
{
    static void Main()
    {
        // Solicita o primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        // Solicita o segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Verifica qual número é maior
        if (numero1 > numero2)
        {
            Console.WriteLine($"O maior número é: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"O maior número é: {numero2}");
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}