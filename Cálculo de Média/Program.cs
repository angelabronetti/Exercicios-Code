using System;

namespace Cálculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
       
        Console.WriteLine("-------------------");

        Console.WriteLine("( 1 ) - Soma");
        Console.WriteLine("( 2 ) - Subtração do 1º número pelo 2º");
        Console.WriteLine("( 3 ) - Subtração do 2º número pelo 1º");
        Console.WriteLine("( 4 ) - Multiplicação");
        Console.WriteLine("( 5 ) - Divisão do 1º número pelo 2º");
        Console.WriteLine("( 6 ) - Divisão do 2º número pelo 1º");
        Console.WriteLine("-------------------");

        string resposta = Console.ReadLine();
        switch(resposta){
            case "1":
                soma = valor1 + valor2;
                Console.WriteLine("O valor de sua soma é: " + soma);
                break;
            case "2":
            sub = valor1 - valor2;
                Console.WriteLine("O valor de sua subtração é: " + sub);
                break;
            case "3":
            sub = valor2 - valor1;
                Console.WriteLine("O valor de sua subtração é: " + sub);
                break;
            case "4":
            multi = valor1 * valor2;
                Console.WriteLine("O valor de sua multiplicação é: "+ multi);
                break;
            case "5":
            if(valor2 <= 0){
                Console.WriteLine("Não é permitido a divisão");
                break;
            
            }else{
                
            div = valor1 / valor2;
                Console.WriteLine("O valor de sua divisão é: " + div);
                break;
            }
            case "6":
            div = valor2 / valor1;
                Console.WriteLine("O valor de sua divisão é: " + div);
                break;
            default:
            Console.WriteLine("Escolha uma operação acima");
            break;
        }
        
        }
    }
}
