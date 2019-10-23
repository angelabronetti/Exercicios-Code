using System;
using Program.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AlunoModel aluno1 = new AlunoModel();

            Console.Clear(); // Limpa tudo que está acima e mostra apenas o que está embaixo

            System.Console.WriteLine("Insira o nome do Modelo");
            aluno1.Modelo = Console.ReadLine();

            System.Console.WriteLine("Insira o Tamanho");
            aluno1.Tamanho = Console.ReadLine();

            System.Console.WriteLine("Insira a cor");
            aluno1.Cor = Console.ReadLine();

            System.Console.WriteLine("Insira a marca");
            aluno1.Marca = Console.ReadLine();

            System.Console.WriteLine("Insira o tipo de lente");
            aluno1.tipoDeLente = Console.ReadLine();

            System.Console.WriteLine("Insira o tipo de grau");
            aluno1.Grau = float.Parse(Console.ReadLine());

            System.Console.WriteLine($@"
            Nome: {aluno1.Modelo}
            Curso: {aluno1.Tamanho}
            Idade: {aluno1.Cor}
            Rg: {aluno1.Marca}
            tipoDeLente: {aluno1.tipoDeLente}
            Grau: {aluno1.Grau}
            ");
        }
    }
}
