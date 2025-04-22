using System;

namespace Exercicios{

    public class Aluno{

        public string nome;
        public double nota1;
        public double nota2;


    public Aluno (string nome, double nota1, double nota2){
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

    public double CalcularMedia (){
        return (nota1 + nota2) / 2;
    }

        public void ExibirResultado(){

            double media = CalcularMedia();
            System.Console.WriteLine("nome do aluno " + nome);
            System.Console.WriteLine("media do aluno" + media);

         if(media >= 6.0){
            Console.WriteLine("Status: Aprovado");
        }else{
            Console.WriteLine("Status: Reprovado");
        }
        }
    }
}