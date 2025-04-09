using System;

class Program
{
    static void Main()
    {
        // Solicita as três notas do usuário
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Calcula a média
        double media = (nota1 + nota2 + nota3) / 3;

        // Exibe a média
        Console.WriteLine($"A média das notas é: {media:F2}"); // Exibe a média com 2 casas decimais
    }
}