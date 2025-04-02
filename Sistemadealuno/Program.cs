//Criar sistema de resultado de aprovado e reprovado
    //Nome do aluno
    //nota1 nota2
    //aprovado e reprovado

using System;
using System.Globalization;
using System.Net;
namespace Sistemadealuno
    
    {
        class Program{

            static void Main(string[] args){

                Console.WriteLine(" Digite o nome do aluno: ");
                string nome = Console.ReadLine ();

                Console.WriteLine ("Digite a primeira nota: ");
                double nota1 = double.Parse(
                    Console.ReadLine (),
                    CultureInfo.InvariantCulture
                );
                   Console.WriteLine ("Digite a primeira nota: ");
                double nota2 = double.Parse(
                    Console.ReadLine (),
                    CultureInfo.InvariantCulture
                );
            }


        }


    }