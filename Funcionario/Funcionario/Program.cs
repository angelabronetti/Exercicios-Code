using System;
using Funcionario.Model;

namespace Funcionario
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Herança");
            FuncionarioModel Funcionario = new FuncionarioModel();

            int opcao;

            do{
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Executar Ações");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    //cadastrar
                    Funcionario.Cadastrar();                
                    break;
                    case 2:
                    //Executar
                    int acao = 0;
                    do{
                        Console.WriteLine($"Selecione uma ação para {Funcionario.Nome}");
                        Console.WriteLine("1 - Andar");
                        Console.WriteLine("2 - Comer");
                        Console.WriteLine("3 - Trabalhar");
                        Console.WriteLine("0 - Sair");
                        acao = int.Parse(Console.ReadLine());

                        switch (acao)
                        {
                            case 1:
                            Funcionario.Andar();
                            break;
                            case 2:
                            Funcionario.Comer();
                            break;
                            case 3:
                            Funcionario.Trabalhar();
                            break;
                            case 0:
                            Console.WriteLine("Tchau!");
                            break;
                            default:
                            Console.WriteLine("Opção Inválida!");
                            break;
                        }

                    }while(acao != 0);                
                    break;
                    case 0:
                    //Sair
                    break;
                    default:
                    //Diferente de 1,2, ou 0
                    break;
                }
            }while (opcao != 0);

        }
    }
}
