using System;
using System.Collections.Generic;
using POOAulaTres.Model;

namespace POOAulaTres {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Aprendendo Herança");

            FuncionarioModel funcionario = new FuncionarioModel ();
            //Criando uma lista Vazia de Funcionários
            List<FuncionarioModel> listaDeFuncionario = new List<FuncionarioModel>();

            int opcao;
            do {
                Console.WriteLine ("Escolha Uma Opção");
                Console.WriteLine ("1 - Cadastrar Funcionario");
                Console.WriteLine ("2 - Executar Ações");
                Console.WriteLine ("0 - Sair");
                opcao = int.Parse (Console.ReadLine ());
                switch (opcao) {
                    case 1:
                        //Cadastrar
                       FuncionarioModel funcionarioCadastrado = funcionario.CadastrarFuncionario();
                       listaDeFuncionario.Add(funcionarioCadastrado);

                       //Vamos listar
                        foreach (var item in listaDeFuncionario)
                        {
                            Console.WriteLine($"Funcionario: {item.Nome}, Cargo: {item.Cargo}");
                        }
                        break;
                    case 2:
                        //Executar
                        int acao = 0;
                        do {
                            Console.WriteLine($"Selecione uma ação para {funcionario.Nome}");
                            Console.WriteLine("1 - Andar");
                            Console.WriteLine("2 - Comer");
                            Console.WriteLine("3 - Trablhar");
                            Console.WriteLine("0 - Sair");
                            acao = int.Parse(Console.ReadLine());
                            switch (acao)
                            {
                                case 1:
                                   funcionario.Andar();
                                break;
                                case 2:
                                funcionario.Comer();
                                break;
                                case 3:
                                funcionario.Trabalhar();
                                break;
                                case 0:
                                Console.WriteLine("Tchau!");
                                break;
                                default:
                                Console.WriteLine("Opção Inválida");
                                break;
                            }//fim switch
                        } while (acao != 0);
                        break;
                    case 0:
                        //Sair
                        break;
                    default:
                        //diferente de 1,2 e 0;
                        break;
                }
            } while (opcao != 0);
        }//fim main
    }
}