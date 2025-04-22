using System;
using System.Globalization;

namespace Exercicios{

    class Program{

            static void Main(string[] args){

                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine ();

                Console.WriteLine("Digite a primeira nota: ");
                double nota11 = double.Parse(
                    Console.ReadLine (),
                    CultureInfo.InvariantCulture

                );

                Console.WriteLine("Digite a segunda nota: ");
                double nota22 = double.Parse(
                    Console.ReadLine(),
                    CultureInfo.InvariantCulture
                );

                Aluno aluno = new Aluno(nome, nota11, nota22);

                aluno.ExibirResultado();
            }
    }

}