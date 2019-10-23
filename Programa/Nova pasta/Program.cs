using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Aprendendo Funções");
            
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultadoDaSoma = SomaDeDoisNumeros(numero1, numero2);

            Console.WriteLine(resultadoDaSoma);

            }// Fim do Main
            /// <sumary> Efetu a soma de dois Número </sumary>
            /// <param name="a"> Primeiro valor do número</param>
            /// <param name="b"> Segundo valor do número </param>
            /// <returns> Retorna a soma dos dois números </returns>

            public static int SomaDeDoisNumeros(int a, int b){
                int soma = a+ b;
                return soma;
            }
            public static string MensagemBoasVindas(){
                return "Bem vindo ao SENAI de Informática";
        }
    }
}
