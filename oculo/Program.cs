using System;
using oculo.Model;

namespace oculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OculoModel oculo1 = new OculoModel();

            Console.Clear(); // Limpa tudo que está acima

            System.Console.WriteLine("Digite o Nome: ")
            oculo1.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o Modelo: ")
            oculo1.Modelo = Console.ReadLine();

            System.Console.WriteLine("Digite o Tamanho: ")
            oculo1.Tamanho = Console.ReadLine();

            System.Console.WriteLine("Digite o Marca: ")
            oculo1.Marca = Console.ReadLine();

            System.Console.WriteLine("Digite o Tipo de Lente: ")
            oculo1.tipoDeLente = Console.ReadLine();

            System.Console.WriteLine($@"
            Nome: {oculo1.Nome}
            Modelo: {oculo1.Modelo}
            Tamanho: {oculo1.Tamanho}
            Marca: {oculo1.Marca}
            Tipo De Lente: {oculo1.tipoDeLente}
            ");
        }
    }
}



{
    
}