using System;
using Exercicio.Controller;

namespace Exercicio
{
    class Program
    {
        private static int opcao;


          
        static void Main(string[] args)
        {   
            ExercicioController exercicioController = new ExercicioController();
            
            int opcao = 0;
            
            do{
                Console.WriteLine("1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Calcular Produtos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

           switch (opcao)
           {
               case 1: 
               //Cadastrar
               exercicioController.CadastroProdutos();
               break;
               case 2:
               //Listar Produtos 
               exercicioController.ListarProduto();
               break;
               case 3:
               //Calcular Produtos
               exercicioController.CalcularProduto();
               break;
               default:
                // Console.WriteLine("Opção Inválida!");
               break;
           }

        }while(opcao != 0);

       
        }

     
            
        }
    }


        