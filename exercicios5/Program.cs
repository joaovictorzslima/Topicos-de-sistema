﻿using System;

class Program
{
    static void Main()
    {
        // Solicita o número ao usuário
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é PAR.");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR.");
        }
    }
}
