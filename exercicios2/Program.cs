using System;

class Program
{
    static void Main()
    {
        // Solicita o ano de nascimento do usuário
        Console.Write("Informe o seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        // Ano atual
        int anoAtual = 2025;

        // Calcula a idade
        int idade = anoAtual - anoNascimento;

        // Exibe a idade
        Console.WriteLine($"Sua idade em {anoAtual} é: {idade} anos.");
    }
}